using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            if(DatenbankAusgebenBesser.i == DatenbankAusgebenBesser.i)
            {
                DatenbankAusgebenBesser();
            }
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
            int Count2 = 0;
            string file = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";

            List<Typen> tiere = new List<Typen>();
            List<string> lines = File.ReadAllLines(file).ToList();

            Console.WriteLine("Über welches Tier willst du etwas erfahren?");
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


           
                Count = 0;
                foreach (var tiereTemp in tiere)
                {
                    //Console.WriteLine(tiereTemp.Tier);
                    Count++;
                    if (tiereTemp.Tier == Tier)
                    {
                        Console.WriteLine("Gefunden " + Count);
                        Console.WriteLine($" Unterordnung: {tiereTemp.Unterordnung} \r\n Tier: {tiereTemp.Tier} \r\n Alter: {tiereTemp.Ewartetes_Alter} \r\n Population: {tiereTemp.Population} \r\n Nahrung: {tiereTemp.Nahrung} \r\n Natürliche Feinde: {tiereTemp.Natürliche_Feinde}");
                        break;
                    }

                }
                int i = File.ReadAllLines(file).Count();
                if (i == i)
                {
                    return i;
                }
            
            Console.WriteLine("Ende");

            


        }
    }
}

