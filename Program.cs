using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NahrungsnetzAuftrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatenbankEinlesen();

            
        }

        static void DatenbankEinlesen()
        {
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            List<string> lines = File.ReadAllLines(file).ToList();

            foreach (string Zeile in lines)
            {
                Console.WriteLine(Zeile);
            }

        }

        static void DatenbankAusgeben()
        {
            Console.WriteLine("Über welches Tier willst du etwas erfahren?");
            
        }
    }
}
