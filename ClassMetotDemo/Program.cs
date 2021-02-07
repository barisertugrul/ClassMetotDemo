using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                MusteriId = 1,
                MusteriAdSoyad = "Pembe Kara",
                MusteriSehir = "İzmir",
                MusteriHesapNo = "00001",
                MusteriBakiye = 180.05
            };

            Musteri musteri2 = new Musteri()
            {
                MusteriId = 2,
                MusteriAdSoyad = "Gümüş Altın",
                MusteriSehir = "Mersin",
                MusteriHesapNo = "00002",
                MusteriBakiye = 4875.38
            };

            Musteri musteri3 = new Musteri()
            {
                MusteriId = 3,
                MusteriAdSoyad = "Çetin Ceviz",
                MusteriSehir = "Elazığ",
                MusteriHesapNo = "00003",
                MusteriBakiye = 21.00
            };

            Musteri musteri4 = new Musteri()
            {
                MusteriId = 4,
                MusteriAdSoyad = "Cuma Çarşambalı",
                MusteriSehir = "Muş",
                MusteriHesapNo = "00004",
                MusteriBakiye = 382.12
            };

            Musteri musteri5 = new Musteri()
            {
                MusteriId = 5,
                MusteriAdSoyad = "Temel Yapıcı",
                MusteriSehir = "Trabzon",
                MusteriHesapNo = "00005",
                MusteriBakiye = 180.05
            };

            //Müşteriler diziye atanıyor
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            //Müşteri Manager örneği oluşturuluyor
            MusteriManager musteriManager = new MusteriManager();

            //------------------------------------------------------------------------------
            //============================= MÜŞTERİ EKLEME SİMÜLASYONLARI ==================
            //------------------------------------------------------------------------------


            //Simülasyon 1: musteriler dizisindeki müşteriler dizi halinde TopluMusteriEkle fonksiyonuna gönderiliyor
            musteriManager.TopluMusteriEkle(musteriler);

            //Simülasyon 2: musteriler dizisine alınmış müşteriler tek tek sırayla gönderilerek ekleniyor
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }

            //Simülasyon 3: Her müşteri tek tek çağrılarak MusteriManager sınıfı içerisindeki MusteriEkle fonksiyonuna gönderiliyor
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);



            //------------------------------------------------------------------------------
            //============================= DİĞER ÖDEV BÖLÜMLERİ ==================
            //------------------------------------------------------------------------------

            //Müşteri listesi çağrılıyor
            musteriManager.MusteriListesi();

            //musteri3 siliniyor
            /*
            * Yukarıdaki simülasyonlarda aynı müşterileri üçer kez eklediğimiz için bu silme işleminde
            * yalnızca ilk muster3 kaydı silinecektir.
            * Gerçek uygulamada, her müşteri otomatik artan bir ID ile yalnızca 1 kez kaydedileceği
            * ve silme işlemi için önce seçim yapılacağı için bu tarz bir sorun olmayacaktır.
            * Örneği fazla karmaşıklaştırmamak için senaryoların yarattığı bu sorun için bir çözüm kodlamadım
            */
            musteriManager.MusteriSil(musteri3);

            //Müşteri listesi tekrar çağrılıyor
            musteriManager.MusteriListesi();

        }
    }
}
