using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine( musteri.TcNo + " Müşteri \n" + "Müşteri Adı ve Soyadı" + musteri.Ad + musteri.Soyad + "\nMüşterinin SSK'sı"+ musteri.SigortaTuru + "\EKLENDİ.");
            Console.WriteLine("-------------------------");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.TcNo + " Müşteri \n" + "Müşteri Adı ve Soyadı" + musteri.Ad + musteri.Soyad + "\nMüşterinin SSK'sı" + musteri.SigortaTuru + "\LİSTELENDİ.");
            Console.WriteLine("-------------------------");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.TcNo + " Müşteri \n" + "Müşteri Adı ve Soyadı" + musteri.Ad + musteri.Soyad + "\nMüşterinin SSK'sı" + musteri.SigortaTuru + "\SİLİNDİ.");
            Console.WriteLine("-------------------------");
        }



    }
}
