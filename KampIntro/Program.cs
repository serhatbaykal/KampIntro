using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategoriler";

            //int ogrenciSayisi = 32000;

            //double faiz = 1.45;

            double dolarDun = 7.35;

            double dolarBugun = 7.45;

            bool systemActive = true;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Düştü.");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Arttı.");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi.");
            }

            if (systemActive == true)
            {
                Console.WriteLine("System Active");
            }
            else
            {
                Console.WriteLine("System Deactive");
            }

        }
    }
}
