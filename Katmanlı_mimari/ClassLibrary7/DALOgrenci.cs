using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace ClassLibrary7
{
     public class DALOgrenci
    {
       public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand k1 = new SqlCommand("insert into tbl2_Ogrenci   (OgrAd, OgrSoyad, OgrNumara, OgrFoto, OgrSıfre)  values (@p1, @p2, @p3, @p4, @p5)", Baglantı.bgl);
            if (k1.Connection.State != ConnectionState.Open)
            {
                k1.Connection.Open();
            }
            k1.Parameters.AddWithValue("@p1", parametre.Ad);
            k1.Parameters.AddWithValue("@p2", parametre.Soyad);
            k1.Parameters.AddWithValue("@p3", parametre.Numara);
            k1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            k1.Parameters.AddWithValue("@p5", parametre.Sifre);

            return k1.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand k2 = new SqlCommand("Select * from tbl2_Ogrenci ", Baglantı.bgl);
            if (k2.Connection.State!=ConnectionState.Open)
            {
                k2.Connection.Open();
            }
            SqlDataReader dr = k2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre2)
        {
            SqlCommand k3 = new SqlCommand("Delete from tbl2_Ogrenci where OGRID=@P1", Baglantı.bgl);
            if (k3.Connection.State != ConnectionState.Open)
            {
                k3.Connection.Open();
            }
            k3.Parameters.AddWithValue("@P1",parametre2);
            return k3.ExecuteNonQuery() > 0;     
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand k4 = new SqlCommand("Select * from tbl2_Ogrenci where OGRID=@P1", Baglantı.bgl);
            k4.Parameters.AddWithValue("@P1", id);
            if (k4.Connection.State != ConnectionState.Open)
            {
                k4.Connection.Open();
            }
            SqlDataReader dr = k4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand k5 = new SqlCommand("Update tbl2_ogrenci set  OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5  WHERE  OGRID=@P6",Baglantı.bgl);
            if (k5.Connection.State!= ConnectionState.Open)
            {
                k5.Connection.Open();       
            }
            k5.Parameters.AddWithValue("@P1", deger.Ad);
            k5.Parameters.AddWithValue("@P2", deger.Soyad);
            k5.Parameters.AddWithValue("@P3", deger.Numara);
            k5.Parameters.AddWithValue("@P4", deger.Fotograf);
            k5.Parameters.AddWithValue("@P5", deger.Sifre);
            k5.Parameters.AddWithValue("@P6", deger.Id);
            return k5.ExecuteNonQuery() > 0;
        }
    }
        
}
