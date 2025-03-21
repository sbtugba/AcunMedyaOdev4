using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev4
{
    class Araba
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public Kapi Kapi { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public decimal Fiyat { get; set; }

        public Araba(Marka marka, string model, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Kapi = kapi;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Arabanın markası {Marka.Ad}, modeli {Model}, kapı sayısı {Kapi.Sayi}, pencere sayısı {Pencere.Sayi}, kasası {Kasa.Tip}, fiyatı {Fiyat:N0} TL’dir.");
        }
    }
}
