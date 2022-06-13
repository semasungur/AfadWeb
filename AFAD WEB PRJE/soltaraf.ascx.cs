using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soltaraf : System.Web.UI.UserControl
{
    metodlar klas = new metodlar(); string kimsin = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        pnlkullanici.Visible = false;
        pnlgiris.Visible = true;



        if (Session["yetki"] != null)
        {
            Lblsonuc.Text = "Sayın" + "&nbsp;" + Session["kimsin"].ToString()+ "&nbsp;" + "Hoşgeldiniz";
          
            pnlkullanici.Visible = true;
            pnlgiris.Visible = false;
        }

    }
    protected void btngiris_Click(object sender, EventArgs e)
    {
         SqlConnection baglanti = klas.baglan();
         SqlCommand cmd = new SqlCommand("select * from personel where kullaniciadisoyadi =@kullaniciadisoyadi AND kullanicisifre=@kullanicisifre", baglanti);
         cmd.Parameters.AddWithValue("@kullaniciadisoyadi", txtkullaniciadi.Text);
         cmd.Parameters.AddWithValue("@kullanicisifre", txtsifre.Text);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            Session["yetki"] = dr["personelid"].ToString();
            Session["kimsin"] = dr["kullaniciadisoyadi"].ToString();
            pnlgiris.Visible = false;
            pnlkullanici.Visible = false;
            Response.Write("<script lang='Javascript'>alert('Giriş Yapıldı! Yönlendiriliyorsunuz'); window.location = 'default.aspx'</script>");
        }
        else
        {
            Lblsonuc.Text="Kullanıcı girişi sağlanamadı";
        }
       
       baglanti.Close();
   }
    protected void btncikis_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect(Request.RawUrl);
    }
    protected void btnkayit_Click(object sender, EventArgs e)
    {
        if (txtkullaniciadi.Text != "" && txtsifre.Text != "")
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert into personel (kullaniciadisoyadi,kullanicisifre) values(@kullaniciadisoyadi,@kullanicisifre)", baglanti);

            cmd.Parameters.AddWithValue("@kullaniciadisoyadi", txtkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@kullanicisifre", txtsifre.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            Lblsonuc.Text = "kaydınız basarıyla yapılmıstır";
      
        }
        else
        {
            Lblsonuc.Text = "alanlarınzı kontrol ediniz";
        }
    }

    public string GetPersonelBilgi()
    {
        return Session["yetki"].ToString();
    }
   
}
    
