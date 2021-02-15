using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Varış";
            kurs3.IzlenmeOrani = 56;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var a in kurslar)
            {
                Console.WriteLine(a.KursAdi + " : " + a.Egitmen + " : " + a.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
