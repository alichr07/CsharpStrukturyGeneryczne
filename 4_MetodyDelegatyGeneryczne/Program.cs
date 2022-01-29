using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<double> drukuj = x => Console.WriteLine(x);

            //drukuj(2.34);

            //Func<double, double> potegowanie = d => d * d;
            //Func<double, double, double> dodaj = (x, y) => x + y;

            //drukuj(potegowanie(5));
            //drukuj(dodaj(10, 20));

            //Predicate<double> jestMniejszeOdSto = d => d < 100;

            //var a = jestMniejszeOdSto(90);
            //var b = jestMniejszeOdSto(140);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            var kolejka = new KolejkaKolowa<double>();

            WprowadzanieDanych(kolejka);

            var jakoData = kolejka.Mapuj(d => new DateTime(2018, 1, 1).AddDays(d));

            foreach (var item in jakoData)
            {
                Console.WriteLine(item);
            }

            kolejka.Drukuj(d => Console.WriteLine(d));

            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscwejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscwejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
