using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : "+ musteri.Adi + musteri.Soyadi);
        }
        public void MusteriSilme(Musteri musteri) 
        {
            Console.WriteLine("Müsteri silindi: "+ musteri.Adi + musteri.Soyadi);
        }
        public void MusterileriListele(Musteri[] musteriler) 
        {
            Console.WriteLine("Musteriler listelendi: ");
            foreach(var musteri in musteriler)
            {
                Console.WriteLine( musteri.Adi + " " + musteri.Soyadi);
            }
        }
    }
}
