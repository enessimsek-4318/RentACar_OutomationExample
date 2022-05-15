using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar
{
    public class Admin
    {
       


        public string kullaniciAdi = "enes";
        public string sifre = "123";
        public string telefonNo = "0536 998 44 38";
        public string adres = "Yunus Emre Mah. No:12346... Yenimahalle / ANKARA ";

        
        public bool sifreKontrol()
        {
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            string gelenKullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            string gelensifre = Console.ReadLine();
            if (gelenKullaniciAdi==kullaniciAdi && gelensifre==sifre)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Bilgisi Yanlış Girilmiştir.");
                return false;
            }
        }
        public int aracTipi()
        {
            Console.WriteLine("Lütfen Eklemek İstediğiniz Araç Tipini Seçiniz:\n1- Otomobil\n2- Ticari Araç\n3- Arazi Aracı\n4- Geri\nLütfen Seçiminizi Yapınız.");
            int eklenenAracSecim = Convert.ToInt32(Console.ReadLine());
            return eklenenAracSecim;
        }
        
        public void aracEkle()
        {
            
        }
        public void iletisimBilgileri()
        {
            Console.WriteLine("Telefon Numarası: " + telefonNo);
            Console.WriteLine("Adres Bilgisi: " + adres);
        }


    }
}
