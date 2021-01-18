using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Neriman";
            musteri1.Soyadi = "Ogulluk";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "irem";
            musteri2.Soyadi = "Ogulluk";
            musteri2.Id = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            /*foreach(var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("------------------");
            } */

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);

            musteriManager.MusterileriListele(musteriler);



        }
    }
}
