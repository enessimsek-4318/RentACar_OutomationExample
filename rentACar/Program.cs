using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Otomobil> otomobiller = new List<Otomobil>();
            Otomobil otomobil = new Otomobil();
            //---------------------------------------------------------
            List<TicariArac> ticariAraclar = new List<TicariArac>();
            TicariArac ticariArac = new TicariArac();
            //---------------------------------------------------------
            List<AraziAraclari> araziAraclar = new List<AraziAraclari>();
            AraziAraclari araziAraclari = new AraziAraclari();
            //---------------------------------------------------------
            Otomobil otomobil1 = new Otomobil();
            otomobil1.marka = "Renault";
            otomobil1.model = "Megane";
            otomobil1.yil = 2018;
            otomobil1.plaka = "34 ES 123";
            otomobil1.gunlukUcret = 280;
            otomobil1.gunlukKmSiniri = 500;
            otomobil1.yakitTipi = "Dizel";
            otomobil1.motorHacmi = 1.5;
            otomobil1.yakitTuketimi = 5.6;
            otomobiller.Add(otomobil1);
            //---------------------------------------------------------
            Otomobil otomobil2 = new Otomobil();
            otomobil2.marka = "Ford";
            otomobil2.model = "Focus";
            otomobil2.yil = 2017;
            otomobil2.plaka = "34 ES 111";
            otomobil2.gunlukUcret = 295;
            otomobil2.gunlukKmSiniri = 500;
            otomobil2.yakitTipi = "Dizel";
            otomobil2.motorHacmi = 1.6;
            otomobil2.yakitTuketimi = 6.7;
            otomobiller.Add(otomobil2);
            //---------------------------------------------------------
            TicariArac ticariArac1 = new TicariArac();
            ticariArac1.marka = "Ford";
            ticariArac1.model = "Tourneo Connect";
            ticariArac1.yil = 2016;
            ticariArac1.plaka = "38 ES 555";
            ticariArac1.gunlukUcret = 320;
            ticariArac1.gunlukKmSiniri = 750;
            ticariArac1.yakitTipi = "Dizel";
            ticariArac1.motorHacmi = 1.8;
            ticariArac1.yakitTuketimi = 9.1;
            ticariAraclar.Add(ticariArac1);
            //---------------------------------------------------------
            TicariArac ticariArac2 = new TicariArac();
            ticariArac2.marka = "Renault";
            ticariArac2.model = "Kangoo";
            ticariArac2.yil = 2015;
            ticariArac2.plaka = "38 ES 666";
            ticariArac2.gunlukUcret = 310;
            ticariArac2.gunlukKmSiniri = 750;
            ticariArac2.yakitTipi = "Dizel";
            ticariArac2.motorHacmi = 1.5;
            ticariArac2.yakitTuketimi = 7.8;
            ticariAraclar.Add(ticariArac2);
            //---------------------------------------------------------
            AraziAraclari araziAraclari1 = new AraziAraclari();
            araziAraclari1.marka = "Toyota";
            araziAraclari1.model = "Hilux";
            araziAraclari1.yil = 2017;
            araziAraclari1.plaka = "06 ES 789";
            araziAraclari1.gunlukUcret = 420;
            araziAraclari1.gunlukKmSiniri = 800;
            araziAraclari1.yakitTipi = "Dizel";
            araziAraclari1.motorHacmi = 2.4;
            araziAraclari1.yakitTuketimi = 13.5;
            araziAraclar.Add(araziAraclari1);
            //---------------------------------------------------------
            AraziAraclari araziAraclari2 = new AraziAraclari();
            araziAraclari2.marka = "Ford";
            araziAraclari2.model = "Ranger";
            araziAraclari2.yil = 2020;
            araziAraclari2.plaka = "06 ES 444";
            araziAraclari2.gunlukUcret = 400;
            araziAraclari2.gunlukKmSiniri = 800;
            araziAraclari2.yakitTipi = "Dizel";
            araziAraclari2.motorHacmi = 2.0;
            araziAraclari2.yakitTuketimi = 11.9;
            araziAraclar.Add(araziAraclari2);
            //---------------------------------------------------------
            Musteri musteri = new Musteri();
            //musteri.tarihBilgisiGir();
            Admin admin = new Admin();
            Arac arac = new Arac();
            while (true)
            {
                Console.WriteLine("1- ARAÇ KAYIT\n2- ARAÇ KİRALAMA\n3- İLETİŞİM BİLGİLERİ\n4- YOL YARDIM\n5- ÇIKIŞ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {

                    bool kontrol = admin.sifreKontrol();
                    while (kontrol)
                    {
                        int eklenenAracSecim = admin.aracTipi();
                        if (eklenenAracSecim == 1)
                        {
                            Console.WriteLine("Lütfen Aracın Markasını Giriniz.");
                            otomobil.marka = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Modelini Giriniz");
                            otomobil.model = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Model Yılını Giriniz.");
                            otomobil.yil = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Plakasını Giriniz.");
                            otomobil.plaka = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Günlük Ücretini Giriniz.");
                            otomobil.gunlukUcret = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Günlük Km Sınırını Giriniz.");
                            otomobil.gunlukKmSiniri = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Yakıt Tipini Giriniz.");
                            otomobil.yakitTipi = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Motor Hacmini Giriniz");
                            otomobil.motorHacmi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın 100 de Kaç Litre Yakıt Tükettiğini Giriniz");
                            otomobil.yakitTuketimi = Convert.ToDouble(Console.ReadLine());
                            otomobiller.Add(otomobil);
                        }
                        else if (eklenenAracSecim == 2)
                        {
                            Console.WriteLine("Lütfen Aracın Markasını Giriniz.");
                            ticariArac.marka = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Modelini Giriniz");
                            ticariArac.model = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Model Yılını Giriniz.");
                            ticariArac.yil = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Plakasını Giriniz.");
                            ticariArac.plaka = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Günlük Ücretini Giriniz.");
                            ticariArac.gunlukUcret = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Günlük Km Sınırını Giriniz.");
                            ticariArac.gunlukKmSiniri = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Yakıt Tipini Giriniz.");
                            ticariArac.yakitTipi = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Motor Hacmini Giriniz");
                            ticariArac.motorHacmi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın 100 de Kaç Litre Yakıt Tükettiğini Giriniz");
                            ticariArac.yakitTuketimi = Convert.ToDouble(Console.ReadLine());
                            ticariAraclar.Add(ticariArac);
                        }
                        else if (eklenenAracSecim == 3)
                        {
                            Console.WriteLine("Lütfen Aracın Markasını Giriniz.");
                            araziAraclari.marka = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Modelini Giriniz");
                            araziAraclari.model = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Model Yılını Giriniz.");
                            araziAraclari.yil = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Plakasını Giriniz.");
                            araziAraclari.plaka = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Günlük Ücretini Giriniz.");
                            araziAraclari.gunlukUcret = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Günlük Km Sınırını Giriniz.");
                            araziAraclari.gunlukKmSiniri = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın Yakıt Tipini Giriniz.");
                            araziAraclari.yakitTipi = Console.ReadLine();
                            Console.WriteLine("Lütfen Aracın Motor Hacmini Giriniz");
                            araziAraclari.motorHacmi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Lütfen Aracın 100 de Kaç Litre Yakıt Tükettiğini Giriniz");
                            araziAraclari.yakitTuketimi = Convert.ToDouble(Console.ReadLine());
                            araziAraclar.Add(araziAraclari);
                        }
                        else if (eklenenAracSecim == 4)
                        {
                            Thread.Sleep(1000);
                            break;
                        }
                        else
                        {
                            hataliIslem();
                        }
                    }
                }
                else if (secim == 2)
                {
                    while (true)
                    {
                        int aracSecim = musteri.aracSec();
                        if (aracSecim == 1)
                        {
                            musteri.otomobilListesiGor(otomobiller);
                            int secimOtomobil = musteri.aracKiralamaSecim();
                            int gun = musteri.tarihBilgisiGir();
                            string musteriBilgisi = musteri.musteriBilgileri();
                            Console.WriteLine("Sayın, {0} Kiralamış Olduğunuz Aracın Bilgilerine Aşağıdan Ulaşabilirsiniz.", musteriBilgisi);
                            Console.WriteLine("Marka: " + otomobiller[secimOtomobil].marka);
                            Console.WriteLine("Model: " + otomobiller[secimOtomobil].model);
                            Console.WriteLine("Model Yılı: " + otomobiller[secimOtomobil].yil);
                            Console.WriteLine("Plaka: " + otomobiller[secimOtomobil].plaka);
                            Console.WriteLine("Ödenen Ücret: " + otomobiller[secimOtomobil].gunlukUcret * gun + " TL");
                            Console.WriteLine("Km Sınırınız: " + otomobiller[secimOtomobil].gunlukKmSiniri * gun + " Km");
                            
                        }
                        else if (aracSecim == 2)
                        {
                            musteri.ticariAracListesiGor(ticariAraclar);
                            int secimTicariArac = musteri.aracKiralamaSecim();
                            int gun = musteri.tarihBilgisiGir();
                            string musteriBilgisi = musteri.musteriBilgileri();
                            Console.WriteLine("Sayın, {0} Kiralamış Olduğunuz Aracın Bilgilerine Aşağıdan Ulaşabilirsiniz.", musteriBilgisi);
                            Console.WriteLine("Marka: " + ticariAraclar[secimTicariArac].marka);
                            Console.WriteLine("Model: " + ticariAraclar[secimTicariArac].model);
                            Console.WriteLine("Model Yılı: " + ticariAraclar[secimTicariArac].yil);
                            Console.WriteLine("Plaka: " + ticariAraclar[secimTicariArac].plaka);
                            Console.WriteLine("Ödenen Ücret: " + ticariAraclar[secimTicariArac].gunlukUcret * gun + " TL");
                            Console.WriteLine("Km Sınırınız: " + ticariAraclar[secimTicariArac].gunlukKmSiniri * gun + " Km");
                        }
                        else if (aracSecim == 3)
                        {
                            musteri.araziAracListesiGor(araziAraclar);
                            int secimAraziAraci = musteri.aracKiralamaSecim();
                            int gun = musteri.tarihBilgisiGir();
                            string musteriBilgisi = musteri.musteriBilgileri();
                            Console.WriteLine("Sayın, {0} Kiralamış Olduğunuz Aracın Bilgilerine Aşağıdan Ulaşabilirsiniz.", musteriBilgisi);
                            Console.WriteLine("Marka: " + araziAraclar[secimAraziAraci].marka);
                            Console.WriteLine("Model: " + araziAraclar[secimAraziAraci].model);
                            Console.WriteLine("Model Yılı: " + araziAraclar[secimAraziAraci].yil);
                            Console.WriteLine("Plaka: " + araziAraclar[secimAraziAraci].plaka);
                            Console.WriteLine("Ödenen Ücret: " + araziAraclar[secimAraziAraci].gunlukUcret * gun + " TL");
                            Console.WriteLine("Km Sınırınız: " + araziAraclar[secimAraziAraci].gunlukKmSiniri * gun + " Km");
                        }
                        else if (aracSecim == 4)
                        {
                            Thread.Sleep(1000);
                            break;
                        }
                        else
                        {
                            hataliIslem();
                        }
                    }


                }
                else if (secim == 3)
                {
                    admin.iletisimBilgileri();
                }
                else if (secim == 4)
                {
                    while (true)
                    {
                        Console.WriteLine("Yol Yardım Talebiniz Alınmıştır. En kısa Sürede Müşteri Temsilcimiz Sizinle İletişime Geçecektir.\n1- Geri");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        if (a1 == 1)
                        {
                            break;
                        }
                    }

                }
                else if (secim == 5)
                {
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI GİRİŞ LÜTFEN TEKRAR GİRİŞ YAPINIZ.");
                }
            }
            
        }
        public static void hataliIslem()
        {
            Console.WriteLine("Hatalı veya Eksik Giriş!");
        }

    }
}
