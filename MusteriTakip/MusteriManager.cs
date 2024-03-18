using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri) {
            Console.WriteLine("MüşteriEkledi !! " + musteri.Ad);

        
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi !! " + musteri.Ad);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi !! " + musteri.Ad);
        }
    }

}
