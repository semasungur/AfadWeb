using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public partial class afetlistele : System.Web.UI.Page
{
    metodlar klas = new metodlar();
    string sorgulama = ""; DateTime Tarih1; DateTime Tarih2;
    protected void Page_Load(object sender, EventArgs e)
    {
        Lbllistelemeuyari.Visible = false;
        if (!IsPostBack)
        {
            AfetDoldur();
           
        }  
    }
    protected void AfetDoldur()
    {
        DropDownList Drafetturu = (DropDownList)PreviousPage.FindControl("Drafetturu");
        DropDownList Drilce= (DropDownList)PreviousPage.FindControl("Drilce");
      

        TextBox Txttarih1 = (TextBox)PreviousPage.FindControl("Txttarih1");
        if (Txttarih1.Text=="")
        {
           Tarih1 = Convert.ToDateTime("01.01.1900");
        }
        else
        {
       Tarih1 = DateTime.Parse(Txttarih1.Text,System.Globalization.CultureInfo.InvariantCulture);
        }

        TextBox Txttarih2 = (TextBox)PreviousPage.FindControl("Txttarih2");
        if (Txttarih1.Text == "")
        {
            Tarih2 = Convert.ToDateTime("01.01.2100");
        }
        else
        {
           Tarih2 = DateTime.Parse(Txttarih2.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
       

        SqlConnection baglanti = klas.baglan();
        sorgulama = "SELECT * FROM afet where 1=1";


      
        if (Drilce.SelectedValue !="")
        {
            sorgulama += " and ilcekatid=@ilcekatid";
        }
        
        if (Drafetturu.SelectedValue !="")
        {
            sorgulama += " and turkatid=@turkatid";
        }
       
        sorgulama += " and tarih >= @Tarih1 and tarih <= @Tarih2 ";

        SqlCommand cmd = new SqlCommand(sorgulama, baglanti);
        cmd.Parameters.AddWithValue("@turkatid", Drafetturu.SelectedValue);
        cmd.Parameters.AddWithValue("@ilcekatid", Drilce.SelectedValue);
        cmd.Parameters.AddWithValue("@Tarih1", Tarih1);
        cmd.Parameters.AddWithValue("@Tarih2", Tarih2);
        SqlDataReader dr = cmd.ExecuteReader();

        DataTable dt = new DataTable("sema");

        dt.Load(dr);

        if (dt.Rows.Count > 0)
        {
            RAfetTuru.DataSource = dt;

            RAfetTuru.DataBind();

           

            baglanti.Close();
        }
        else
        {
            Lbllistelemeuyari.Visible = true;
            Lbllistelemeuyari.Text = "Aradığınız Kriterde Herhangi Bir Kayıt Yoktur.";
        }
    }
    protected void RAfetTuru_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem )
        {
            CheckBoxList CheckBoxList1 = (CheckBoxList)PreviousPage.FindControl("CheckBoxList1");
            int afetid = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "afetid"));
            GridView GridView2 = (GridView)e.Item.FindControl("GridView2");
            SqlConnection baglanti = klas.baglan();
            string sorgulama = "select * from afetistatistik where afetkatid='"+ afetid+"'";

          

            string parametre = "";
            int sira = 0;
            for (int k = 0; k < CheckBoxList1.Items.Count; k++)
            {
                if (CheckBoxList1.Items[k].Selected)
                {
                    sira++;
                    if (sira > 1)
                    {
                        parametre += ",";
                    }
                    parametre += "'" + CheckBoxList1.Items[k].Text + "'";
                }
            }
            if (CheckBoxList1.SelectedIndex != -1)
            {
                sorgulama += " and afetistatistikadi IN (" + parametre + ")";
            }
           

            SqlCommand cmd = new SqlCommand(sorgulama, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable("sema");

            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                GridView2.DataSource = dt;

                GridView2.DataBind();

               

                baglanti.Close();
            }
            else
            {

                
            }
        }
        }

    }
