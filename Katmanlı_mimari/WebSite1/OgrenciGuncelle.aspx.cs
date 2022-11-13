using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary7;
using BusinessLogicLayer;
using EntityLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
        Textıd.Text = x.ToString();
        Textıd.Enabled = false;

        if (Page.IsPostBack==false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
            Textad.Text = OgrList[0].Ad.ToString();
            Textsoyad.Text = OgrList[0].Soyad.ToString();
            Textno.Text = OgrList[0].Numara.ToString();
            Textfoto.Text = OgrList[0].Fotograf.ToString();
            Textpass.Text = OgrList[0].Sifre.ToString();
        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = Textad.Text;
        ent.Soyad = Textsoyad.Text;
        ent.Sifre = Textpass.Text;
        ent.Numara = Textno.Text;
        ent.Fotograf = Textfoto.Text;
        ent.Id = Convert.ToInt32(Textıd.Text);

        BLLOgrenci.OgrenciGuncelle(ent);
        Response.Redirect("OgrenciListesi.aspx");

    }
}