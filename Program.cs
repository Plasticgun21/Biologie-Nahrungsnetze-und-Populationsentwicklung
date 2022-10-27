using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

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
            int Count = 0;
            bool temp = false;
            string input;
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";

            List<Typen> tiere = new List<Typen>();
            List<string> lines = File.ReadAllLines(file).ToList();

            int AnzahlTiereTemp = File.ReadAllLines(file).Count();
            
            Console.WriteLine($"Über welches Tier willst du etwas erfahren? In der Datenbank exestieren momentan {AnzahlTiereTemp} Tiere!");
            Tier = Console.ReadLine();

            

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

                tiere.Add(newTypen);

                
            }


            while (true)
            {
                Count = 0;
                temp = false;
                foreach (var tiereTemp in tiere)
                {
                    //Console.WriteLine(tiereTemp.Tier);
                    Count++;
                    if (tiereTemp.Tier == Tier)
                    {
                        Console.WriteLine($"Gefunden auf Zeile {Count}");
                        Console.WriteLine($" Unterordnung: {tiereTemp.Unterordnung} \r\n Tier: {tiereTemp.Tier} \r\n Alter: {tiereTemp.Ewartetes_Alter} \r\n Population: {tiereTemp.Population} \r\n Nahrung: {tiereTemp.Nahrung} \r\n Natürliche Feinde: {tiereTemp.Natürliche_Feinde}");
                        temp = true;
                        break;
                    }

                }
                if(temp == true)
                {
                    break;
                }
                Console.WriteLine("Tier wurde nicht gefunden haben sie es richtig geschrieben? y | n");
                input = Console.ReadLine();
                if(input == "y")
                {
                    Console.WriteLine("Möchten sie es hinzufügen?");
                    break;
                }
                else if (input == "n")
                {
                    Console.Write("Geben sie das Tier erneut ein: ");
                    Tier = Console.ReadLine();
                }
            }

            
            
            Console.WriteLine("------------- Ende ---------------");

            


        }
    }
}

