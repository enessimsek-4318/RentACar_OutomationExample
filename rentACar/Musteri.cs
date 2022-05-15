using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar
{
    public class Musteri
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefonNo { get; set; }
        public long hesapNo { get; set; }
        public string email { get; set; }
        
        
        public int aracSec()
        {
            Console.WriteLine("Lütfen Kiralamak İstediğiniz Arac Tipini Seçiniz:\n1- Otomobil\n2- Ticari Araç\n3- Arazi Aracı\n4- Geri\nLütfen Seçiminizi Yapınız.");
            int aracSecim = Convert.ToInt32(Console.ReadLine());
            return aracSecim;
        }
        public int tarihBilgisiGir()
        {
            DateTime bugununTarihi = DateTime.Now;
            Console.WriteLine("Tarih: " + bugununTarihi);
            Console.WriteLine("Lütfen Aracı alacağınız Tarihi Giriniz:\nGün:");
            int gun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ay:");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yıl:");
            int yil = Convert.ToInt32(Console.ReadLine());
            DateTime almaGunu = new DateTime(yil, ay, gun);
            Console.WriteLine("Aracı Kaç Gün Kiralamak İstediğinizi Giriniz:");
            int kiralananGunSayisi = Convert.ToInt32(Console.ReadLine());
            almaGunu = almaGunu.AddDays(kiralananGunSayisi);
            Console.WriteLine("Aracı Teslim Etmeniz Gereken Tarih: " + almaGunu);
            return kiralananGunSayisi;
        }

        public void otomobilListesiGor(List<Otomobil> otomobiller)
        {
            int sayac = 1;
            foreach (Otomobil item in otomobiller)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("{0} Numaralı Araç Bilgileri:", sayac);
                Console.WriteLine("Marka: " + item.marka);
                Console.WriteLine("Model: " + item.model);
                Console.WriteLine("Model Yılı: " + item.yil);
                Console.WriteLine("Plaka: " + item.plaka);
                Console.WriteLine("Günlük Ücret: " + item.gunlukUcret + " TL");
                Console.WriteLine("Günlük Km Sınırı: " + item.gunlukKmSiniri + " Km");
                Console.WriteLine("Yakıt Tipi: " + item.yakitTipi);
                Console.WriteLine("Motor Hacmi: " + item.motorHacmi);
                Console.WriteLine("100 Km'de Yakıt Tüketimi (Litre): " + item.yakitTuketimi);
                sayac++;
            }

        }
        public void ticariAracListesiGor(List<TicariArac> ticariAraclar)
        {
            int sayac = 1;
            foreach (TicariArac item in ticariAraclar)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("{0} Numaralı Araç Bilgileri:", sayac);
                Console.WriteLine("Marka: " + item.marka);
                Console.WriteLine("Model: " + item.model);
                Console.WriteLine("Model Yılı: " + item.yil);
                Console.WriteLine("Plaka: " + item.plaka);
                Console.WriteLine("Günlük Ücret: " + item.gunlukUcret + " TL");
                Console.WriteLine("Günlük Km Sınırı: " + item.gunlukKmSiniri + " Km");
                Console.WriteLine("Yakıt Tipi: " + item.yakitTipi);
                Console.WriteLine("Motor Hacmi: " + item.motorHacmi);
                Console.WriteLine("100 Km'de Yakıt Tüketimi (Litre): " + item.yakitTuketimi);
                sayac++;
            }
        }
        public void araziAracListesiGor(List<AraziAraclari> araziAraclar)
        {
            int sayac = 1;
            foreach (AraziAraclari item in araziAraclar)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("{0} Numaralı Araç Bilgileri:", sayac);
                Console.WriteLine("Marka: " + item.marka);
                Console.WriteLine("Model: " + item.model);
                Console.WriteLine("Model Yılı: " + item.yil);
                Console.WriteLine("Plaka: " + item.plaka);
                Console.WriteLine("Günlük Ücret: " + item.gunlukUcret + " TL");
                Console.WriteLine("Günlük Km Sınırı: " + item.gunlukKmSiniri + " Km");
                Console.WriteLine("Yakıt Tipi: " + item.yakitTipi);
                Console.WriteLine("Motor Hacmi: " + item.motorHacmi);
                Console.WriteLine("100 Km'de Yakıt Tüketimi (Litre): " + item.yakitTuketimi);
                sayac++;
            }
        }
        public string musteriBilgileri()
        {
            Console.WriteLine("Müşteri Kayıt İşlemi:\nAdınız:");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            soyad = Console.ReadLine();
            Console.WriteLine("Telefon Numaranız:");
            telefonNo = Console.ReadLine();
            Console.WriteLine("Hesap Numaranız:");
            hesapNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("E-posta Adresiniz:");
            email = Console.ReadLine();
            string adSoyad = ad + " " + soyad;
            return adSoyad;
        }
        public int aracKiralamaSecim()
        {
            Console.WriteLine("Lütfen Kiralamak İstediğiniz Aracın Numarasını Giriniz.");
            int secim = Convert.ToInt32(Console.ReadLine());
            return secim-1;
        }

    }
}
