using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int Cikarim = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " +Cikarim);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int Carpim = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + Carpim);
        }
        public void bol(int sayi1, int sayi2)
        {
            int bolum = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + bolum);
        }
    }
}