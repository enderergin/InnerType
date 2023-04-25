using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class MusteriSiparisBilgisi
    {
        public string siparisno { get; set; }

        public urun[] urunler;

        public MusteriSiparisBilgisi()
        {
            urunler = new urun[2];
            
        }

        public void siparis() 
        {

            Console.WriteLine("test");
        
        }
    }
}
