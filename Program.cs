using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace NahrungsnetzAuftrag
{
    internal class Program
    {
        
        static void Main(string[] args)
        {




            Auslesen();
            string[] Zeilen = new string[0];

        }

        static void Auslesen()
        {
            string DateiPfad = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            string[] Zeilen = File.ReadAllLines(DateiPfad);

            string[] Unterordnung = new string[Zeilen.Length];
            string[] Tier = new string[Zeilen.Length];
            string[] Ewartetes_Alter = new string[Zeilen.Length];
            string[] Population = new string[Zeilen.Length];
            string[] Nahrung = new string[Zeilen.Length];
            string[] Natürliche_Feinde = new string[Zeilen.Length];

            int Count = 0;
            string[] Temp = new string[5];

            foreach (string zeile in Zeilen)
            {
                Temp = zeile.Split(';');
                Unterordnung[Count] = Temp[0];
                Tier[Count] = Temp[1];
                Ewartetes_Alter[Count] = Temp[2];
                Population[Count] = Temp[3];
                Nahrung[Count] = Temp[4];
                Natürliche_Feinde[Count] = Temp[5];
                Count++;

            }

            Console.WriteLine($"Über welches Tier willst du etwas erfahren? In der Datenbank exestieren momentan {Zeilen.Length} Tiere!");
            string Tier = Console.ReadLine();

            while (true)
            {
                Count = 0;
                bool temp = false;
                foreach (var tiereTemp in Tier)
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
                if (temp == true)
                {
                    break;
                }
                Console.WriteLine("Tier wurde nicht gefunden haben sie es richtig geschrieben? y | n");
                input = Console.ReadLine();
                if (input == "y")
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

            foreach (string z in Tier)
            {
                Console.WriteLine(z);
            }

        }
        static void Quiz()
        {

        }
    }
}

