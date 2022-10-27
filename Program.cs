using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NahrungsnetzAuftrag
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DatenbankEinlesen();
            DatenbankAusgeben();

            
        }

        static void DatenbankEinlesen()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            List<string> lines = File.ReadAllLines(file).ToList();




        }

        static void DatenbankAusgeben()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            List<string> lines = File.ReadAllLines(file).ToList();

            Console.WriteLine("Über welches Tier willst du etwas erfahren?");
            foreach (string Zeile in lines)
            {
                string[] entries = Zeile.Split(';');
            }

        }
    }
}

