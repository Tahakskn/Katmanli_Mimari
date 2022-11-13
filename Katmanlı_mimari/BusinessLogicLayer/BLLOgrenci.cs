﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary7;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null  && p.Soyad != null && p.Numara != null && p.Fotograf != null && p.Sifre!=null )
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL (int p )
        {
                if (p>=0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelle (EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad != "" && p.Soyad != null && p.Numara != null && p.Fotograf != null && p.Sifre != null && p.Id>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
            
        }
    }
}
