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


public partial class afetekleme2 : System.Web.UI.Page
{
    metodlar klas = new metodlar();
    string personelid = ""; string afetid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        personelid = injection.temizle(Request.QueryString["personelid"].ToString());
        afetid = injection.temizle(Request.QueryString["afetid"].ToString());
        if (!IsPostBack)
        {
            istatistikdoldur();
        }

        if (Session["yetki"] == null)
        {

            Response.Redirect("default.aspx");
        }
    }

   protected void istatistikdoldur()
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("select * from istatistikbilgi", baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        DataTable dt = new DataTable("sema");
        dt.Load(dr);
       if (dt.Rows.Count>0)
       {
           DLVeri.DataSource = dt;
           DLVeri.DataBind();
       }
    }
   protected void BtnDevam_Click(object sender, EventArgs e)
   {
       foreach (DataListItem item in DLVeri.Items)
       {
           Label Lblistatistikadi = (Label)item.FindControl("Lblistatistikadi");
           TextBox Txtsayi =(TextBox)item.FindControl("txtsayi");
           SqlConnection baglanti = klas.baglan();
           SqlCommand cmd = new SqlCommand("insert into afetistatistik (afetistatistikadi,afetistatistikdeger,afetkatid,personelkatid) values (@afetistatistikadi,@afetistatistikdeger,@afetkatid,@personelkatid);",baglanti);
           cmd.Parameters.AddWithValue("afetkatid", afetid);
           cmd.Parameters.AddWithValue("personelkatid", personelid);
           cmd.Parameters.AddWithValue("afetistatistikadi", Lblistatistikadi.Text);
           if(Txtsayi.Text =="")
           {
               cmd.Parameters.AddWithValue("afetistatistikdeger", 0);

           }
           else
           {
               cmd.Parameters.AddWithValue("afetistatistikdeger", Txtsayi.Text);
           }
           cmd.ExecuteNonQuery();
           Response.Write("<script lang='Javascript'>alert('Kayıt Başarıyla Yapıldı!'); window.location = 'default.aspx'</script>");
       }
   }
}