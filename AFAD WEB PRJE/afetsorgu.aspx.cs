using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class afetsorgu : System.Web.UI.Page
{
    metodlar klas = new metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["PreviousValue"] = CheckBoxList1.SelectedValue;
            AfetDoldur();
            ilceDoldur();
            afetturuDoldur();
        }  
    }
    protected void AfetDoldur()
    {
        string sql = "select * from istatistikbilgi";
        DataTable dtafetcecekme = klas.GetDataTable(sql);
        CheckBoxList1.DataSource = dtafetcecekme;
        CheckBoxList1.DataTextField = "istatistikadi";
        CheckBoxList1.DataValueField = "istatistikid";
        
        CheckBoxList1.DataBind();
    }

       protected void afetturuDoldur()
       {
           string sql = "select *  from afetturu";
           DataTable dtafetturucekme = klas.GetDataTable(sql);
           Drafetturu.DataSource = dtafetturucekme;
           Drafetturu.DataTextField = "turadi";
           Drafetturu.DataValueField = "turid";
          
           Drafetturu.DataBind();
           Drafetturu.Items.Insert(0, new ListItem("Seçiniz...", ""));
       }
    protected void ilceDoldur()
    {
        string sql = "select *  from ilce";
        DataTable dtilcececekme = klas.GetDataTable(sql);
        Drilce.DataSource = dtilcececekme;
        Drilce.DataTextField = "ilceadi";
        Drilce.DataValueField = "ilceid";
       
        Drilce.DataBind();
        Drilce.Items.Insert(0, new ListItem("Seçiniz...", ""));
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["NewValue"] = CheckBoxList1.SelectedValue;
        ViewState["PreviousValue"] = ViewState["NewValue"];   
    }
}
