using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Musteri
    {
        #region
        public string isim;
        public string soyisim;
        public int tc;
        public int MusteriID;
        public int KullaniciID;
        public DateTime Tarih;
        #endregion
        #region
        public MusteriAdres[] Musteriadresleri; // class içinde değer ismini yazdın
        public MusteriBilgisi[] MusteriBilgileri;
        public MusteriSiparisBilgisi[] MusteriSiparisBilgileri;
        #endregion
        #region
        public Musteri()
        {
            Musteriadresleri = new MusteriAdres[5]; // listenin kaç object tutacağını belirledin
            MusteriBilgileri = new MusteriBilgisi[5];
            MusteriSiparisBilgileri = new MusteriSiparisBilgisi[5];
        }
        #endregion

        

    }
}
