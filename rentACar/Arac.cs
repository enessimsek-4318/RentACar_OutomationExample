using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar
{
    public class Arac
    {
        // public string marka; ---->>> Field Tanımlamak..
        // public string marka { get; set; } ---->>> Property Tanımlamak..
        // ikisi arasındaki temel fark encapsulation kullanımıdır. 
        public string marka { get; set; }
        public string model { get; set; }
        public int yil { get; set; }
        public string plaka { get; set; }
        public int gunlukUcret { get; set; }
        public int gunlukKmSiniri { get; set; }
        public string yakitTipi { get; set; }
        public double motorHacmi { get; set; }
        public double yakitTuketimi { get; set; }
        
        public void aracKiralama()
        {

        }
        public void tarihUygunmu()
        {

        }
        public void kmBilgisiAl()
        {

        }
        public void yakitTuketimiHesapla()
        {

        }
    }
}
