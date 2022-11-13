using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using ClassLibrary7;

public partial class Default2 :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = Textad.Text;
        ent.Soyad = Textsoyad.Text;
        ent.Numara = Textno.Text;
        ent.Sifre = Textpass.Text;
        ent.Fotograf = Textfoto.Text;
        BLLOgrenci.OgrenciEkleBLL(ent);
    }
}