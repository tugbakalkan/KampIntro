﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string UrunAdi, string Aciklama , double Fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + UrunAdi);
        }
    }
}
