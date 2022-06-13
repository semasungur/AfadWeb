using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
using System.IO;


public partial class afetekleme : System.Web.UI.Page
{
    metodlar klas = new metodlar();
    string personelid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        personelid = injection.temizle(Request.QueryString["personelid"].ToString());

        if (!IsPostBack)
        { 
            afetturuDoldur();
            ilceDoldur();
          //  istatistikdoldur();
        }

        if (Session["yetki"] == null)
        {

            Response.Redirect("default.aspx");
        }
    }

    protected void afetturuDoldur()
    {
        string sql = "select *  from afetturu";
        DataTable dtafetturucekme = klas.GetDataTable(sql);
        DropAfetTuru.DataSource = dtafetturucekme;
        DropAfetTuru.DataTextField = "turadi";
        DropAfetTuru.DataValueField = "turid";
        DropAfetTuru.DataBind();
    }

    protected void ilceDoldur()
    {
        string sql = "select *  from ilce";
        DataTable dtilcececekme = klas.GetDataTable(sql);
        Dropilce.DataSource = dtilcececekme;
        Dropilce.DataTextField = "ilceadi";
        Dropilce.DataValueField = "ilceid";
        Dropilce.DataBind();
    }
   
    protected void BtnDevam_Click(object sender, EventArgs e)
    {

        if (FileUpload1.HasFile)
        {
            string dosyauzantisi = Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (dosyauzantisi.ToLower() == ".png" || dosyauzantisi.ToLower() == ".jpg" || dosyauzantisi.ToLower() == ".jpeg")
            {
                fotograf.yukle(FileUpload1, 800);
                Image1.ImageUrl = "picture_library/" + FileUpload1.FileName;
            }

            else
            {

            }
        }
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into afet (afetadi,turkatid,ilcekatid,tarih,aciklama,personelkatid,img) values(@afetadi,@turkatid,@ilcekatid,@tarih,@aciklama,@personelkatid,@img);select scope_identity()", baglanti);

            
            cmd.Parameters.AddWithValue("@afetadi", TxtAfetAdi.Text);
            cmd.Parameters.AddWithValue("@turkatid", DropAfetTuru.SelectedValue);
            cmd.Parameters.AddWithValue("@ilcekatid", Dropilce.SelectedValue);
            cmd.Parameters.AddWithValue("@personelkatid", personelid);
            cmd.Parameters.AddWithValue("@aciklama", TxtAciklama.Text);
            cmd.Parameters.AddWithValue("@img", Image1.ImageUrl);
            DateTime date1 = DateTime.Parse(TxtTarih.Text,System.Globalization.CultureInfo.InvariantCulture); 
            cmd.Parameters.AddWithValue("@tarih", date1);
            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            Response.Redirect("afetekleme2.aspx?personelid=" + personelid + "&afetid=" + sonuc + "");
           
    }
}