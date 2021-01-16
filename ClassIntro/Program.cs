using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 35;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Furkan Yılmaz";
            kurs1.IzlenmeOrani = 27;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Necati Çevik";
            kurs2.IzlenmeOrani = 38;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Eda Eroğlu";
            kurs3.IzlenmeOrani = 42;

            //Console.WriteLine(kurs1.KursAdi+ " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Eğitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
