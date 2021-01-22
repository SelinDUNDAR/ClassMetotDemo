using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İş Bankası'na Hoş Geldiniz.");   
            Musteri musteri1 = new Musteri();
            musteri1.TcNo = 12345671;
            musteri1.Ad = "Selin";
            musteri1.Soyad = "DÜNDAR";
            musteri1.SigortaTuru = "bağkur";

            Musteri musteri2 = new Musteri();
            musteri2.TcNo = 987654309;
            musteri2.Ad = "Alparslan";
            musteri2.Soyad = "CEYLAN";
            musteri2.SigortaTuru = "emekli sandığı";

            Musteri musteri3 = new Musteri();
            musteri3.TcNo = 11111111;
            musteri3.Ad = "Mahmut";
            musteri3.Soyad = "FIRAT";
            musteri3.SigortaTuru = "bağkur";

            Musteri musteri4= new Musteri();
            musteri4.TcNo = 222222222;
            musteri4.Ad = "Ayşe";
            musteri4.Soyad = "FIRAT";
            musteri4.SigortaTuru = "emekli sandığı";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSil(musteri4);












        


        }
    }
}
