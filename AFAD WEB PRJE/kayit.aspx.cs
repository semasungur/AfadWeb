using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kayit : System.Web.UI.Page
{
    metodlar klas = new metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
       
           
          
    }
    protected void btnkayit_Click(object sender, EventArgs e)
    {
        if(txtkullaniciadi.Text !="" && txtsifre.Text != "" ) 
        {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Insert into personel (kullanici_adisoyadi,kullanici_sifre) values(@kullanici_adisoyadi,@kullanici_sifre)", baglanti);

        cmd.Parameters.AddWithValue("@kullanici_adisoyadi", txtkullaniciadi.Text);
        cmd.Parameters.AddWithValue("@kullanici_sifre", txtsifre.Text);

        cmd.ExecuteNonQuery();
        baglanti.Close();
        lblsonuc.Text = "kaydınız basarıyla yapılmıstır";
        }
        else
        {
            lblsonuc.Text = "alanlarınzı kontrol ediniz";
        }

    }
}