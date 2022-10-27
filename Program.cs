using System;

namespace NahrungsnetzAuftrag
{
    internal class Program
    {
        public string Dateipfad = @"";

        static void Main(string[] args)
        {

        }

        static void DatenbankEinlesen()
        {
            string[] lines = File.ReadAllLines(textFile);
        }

        static void DatenbankAusgeben()
        {
            Console.WriteLine("Über welches Tier willst du etwas erfahren?");
            
        }
    }
}
