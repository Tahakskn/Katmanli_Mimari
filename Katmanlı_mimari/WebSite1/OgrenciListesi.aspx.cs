using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary7;
using BusinessLogicLayer;
using EntityLayer;

public partial class OgrenciListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> Ogrlist = BLLOgrenci.BllListele();
        Repeater1.DataSource = Ogrlist;
        Repeater1.DataBind();
    }
}