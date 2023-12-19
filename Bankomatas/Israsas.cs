using System;
namespace Bankomatas
{
    public class Israsas
    {
        const string path = "/Users/urte.balciunaitevinted.com/Projects/Bankomatas/Bankomatas/Israsas.txt";

        public Israsas()
        {

        }

        public static void PridetiNaujaTransakcija(decimal Suma, DateTime Data, string Valiuta, string MokejimoPaskirtis)
        {
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine($"{Suma}, {Data}, {Valiuta}, {MokejimoPaskirtis}");

            writer.Close();
        }

        public static void SkaitytiIsrasa()
        {
            Console.Clear();

            StreamReader reader = new StreamReader(path);

            string? line = reader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}

