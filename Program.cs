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
            DatenbankAusgebenBesser(); 
        }

        static void DatenbankAusgeben()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string Tier;
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            List<string> lines = File.ReadAllLines(file).ToList();
            Console.WriteLine("Über welches Tier willst du etwas erfahren?");
            Tier = Console.ReadLine();

            foreach (string Zeile in lines)
            {
                string[] entries = Zeile.Split(';');
            }

        }

        static void DatenbankAusgebenBesser()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string Tier;
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";

            List<Typen> tiere = new List<Typen>();
            List<string> lines = File.ReadAllLines(file).ToList();

            Console.WriteLine("Über welches Tier willst du etwas erfahren?");

            foreach (var Zeile in lines)
            {
                string[] einträge = Zeile.Split(';');
                Typen newTypen = new Typen();
                newTypen.Unterordnung = einträge[0];
                newTypen.Tier = einträge[1];
                newTypen.Ewartetes_Alter = einträge[2];
                newTypen.Population = einträge[3];
                newTypen.Nahrung = einträge[4];
                newTypen.Natürliche_Feinde = einträge[5];
                newTypen.Funfact = einträge[6];

            }
            foreach (var tiereTemp in tiere)
            {
                Console.WriteLine($"{tiereTemp.Tier}");
            }

          
        }
    }
}

