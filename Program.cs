﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri x1 = new Musteri();
            x1.MusteriID = 1;
            x1.isim = "ender";
            x1.tc = 123;
            x1.soyisim = "ergin";
            x1.Tarih = DateTime.Now;


            x1.Musteriadresleri[0] = new MusteriAdres() // 'Musteriadresleri' fieldı kullandığın ana class içinde Array olarak bulunduğu için oradanda gideceği konumu belirttin(zorundasın) zorundasın 
            {
                il = "hatay", // Musteri adres classının içinde belirttiğin fieldlar
                ilce = "iskenderun",
                adresi = "dumlupınar"

            };

            x1.Musteriadresleri[0].adres();

            x1.MusteriSiparisBilgileri[0] = new MusteriSiparisBilgisi() // önce sipariş bilgisini oluştumak gerekiyorki MusteriSiparisBilgileri class'nın içindeki 'urunler' dizisine gidebilmelisin
            {
                siparisno = "12321" //MusteriSiparisBilgileri Class'ının içinde bir tane değer atamalısınki aşşağıdaki 'urunler' diziside çalışabilsin.Yoksa classın içinde önce metota giriyor ve metotun üstündeki diziyi okumuyor
            };
            x1.MusteriSiparisBilgileri[0].urunler[0] = new urun() //fieldın gideceği yeri tamamını belirtmelisin
            {
                fiyat = 10000,
                tanim = "telefon",
                urunID = 111
            };
            Console.ReadLine();

        }
    }
}
