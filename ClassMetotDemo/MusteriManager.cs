using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriListesi = new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {
            //musteriListesi.Insert(musteri.MusteriId-1,musteri);
            musteriListesi.Add(musteri);
            Console.WriteLine("{0} isimli müşteri eklendi.", musteri.MusteriAdSoyad);
        }

        public void TopluMusteriEkle(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                //musteriListesi.Insert(musteri.MusteriId-1,musteri);
                musteriListesi.Add(musteri);
                Console.WriteLine("{0} isimli müşteri eklendi.", musteri.MusteriAdSoyad);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("{0} nolu ve {1} isimli müşteri silindi.\n", musteri.MusteriId, musteri.MusteriAdSoyad);
            musteriListesi.Remove(musteri);
        }

        public void MusteriListesi()
        {
            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("************************************ MÜŞTERİ  LİSTESİ ************************************");
            Console.WriteLine("==========================================================================================\n\n");
            Console.WriteLine("Müşteri ID        \tMüşteri Adı-Soyadı\tŞehir             \tBakiye            ");
            Console.WriteLine("==================\t==================\t==================\t==================");
            foreach (Musteri musteri in musteriListesi)
            {
                Console.WriteLine("     " + musteri.MusteriId + "            \t"
                    + musteri.MusteriAdSoyad + "        \t"
                    + musteri.MusteriSehir + "             \t"
                    + musteri.MusteriBakiye);
            }
            Console.WriteLine("==========================================================================================");
        }
    }
}
