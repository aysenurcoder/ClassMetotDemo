using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Hasan";
            musteri1.SoyAdi = "Kara";
            musteri1.Yasi = 35;
            musteri1.Meslegi = "Doktor";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Tahsin";
            musteri2.SoyAdi = "Mutlu";
            musteri2.Yasi = 27;
            musteri2.Meslegi = "Savcı";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ayşe";
            musteri3.SoyAdi = "Yaprak";
            musteri3.Yasi = 43;
            musteri3.Meslegi = "Mühendis";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Birsel";
            musteri4.SoyAdi = "Karaman";
            musteri4.Yasi = 35;
            musteri4.Meslegi = "Aşçı";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.SoyAdi);
                Console.WriteLine("Müşteri Yaşı : " + musteri.Yasi);
                Console.WriteLine("Müşteri Mesleği : " + musteri.Meslegi);
                Console.WriteLine("*********************************");
            }


        }
    }
}
