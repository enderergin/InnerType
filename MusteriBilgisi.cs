using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class MusteriBilgisi
    {
        public int iletisimTipi { get; set; }
        public string alankodu { get; set; }
        public string numara { get; set; }
        public bool aktiflik { get; set; }


        public void iletisim()
        {
            Console.WriteLine("test");
        }
    }
}
