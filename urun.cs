using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class urun
    {
        public int urunID;
        public string tanim;
        public decimal fiyat;

        public urun()
        {
            Console.WriteLine("ürün yapıcı metotda çalıştı");
        }

        public void uruntest() 
        { 
            Console.WriteLine("Ürün test");
        }

    }
}
