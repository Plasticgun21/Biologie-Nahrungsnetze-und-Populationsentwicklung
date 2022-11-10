using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Intro();
        }
        static void Intro()
        {
            Console.WriteLine("Willkommen im Biologie Menu");
            Console.WriteLine("Sie können mit den Pfeiltasten im Biologie Menu navigieren");

            string prompt = "███╗   ██╗ █████╗ ██╗  ██╗██████╗ ██╗   ██╗███╗   ██╗ ██████╗ ███████╗███╗   ██╗███████╗████████╗███████╗\r\n████╗  ██║██╔══██╗██║  ██║██╔══██╗██║   ██║████╗  ██║██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝╚══███╔╝\r\n██╔██╗ ██║███████║███████║██████╔╝██║   ██║██╔██╗ ██║██║  ███╗███████╗██╔██╗ ██║█████╗     ██║     ███╔╝ \r\n██║╚██╗██║██╔══██║██╔══██║██╔══██╗██║   ██║██║╚██╗██║██║   ██║╚════██║██║╚██╗██║██╔══╝     ██║    ███╔╝  \r\n██║ ╚████║██║  ██║██║  ██║██║  ██║╚██████╔╝██║ ╚████║╚██████╔╝███████║██║ ╚████║███████╗   ██║   ███████╗\r\n╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚══════╝";
            string[] options = { "Datenbank","Quiz","Diagramm" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            if(selectedIndex == 0)
            {
                Console.Clear();
                Auslesen();
            }
            else if(selectedIndex == 1)
            {
                Console.Clear();
                Quitz();
            }
            else if(selectedIndex == 2)
            {
                Console.Clear();
                Populationsdiagramm();

            }


            
        }

        static void Auslesen()
        {
            string DateiPfad = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            string[] Zeilen = File.ReadAllLines(DateiPfad) ;

            string[] Unterordnung = new string[Zeilen.Length];
            string[] Tier = new string[Zeilen.Length];
            string[] Erwartetes_Alter = new string[Zeilen.Length];
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
                Erwartetes_Alter[Count] = Temp[2];
                Population[Count] = Temp[3];
                Nahrung[Count] = Temp[4];
                Natürliche_Feinde[Count] = Temp[5];
                Count++;
                
            }

            string prompt = "██████╗  █████╗ ████████╗███████╗███╗   ██╗██████╗  █████╗ ███╗   ██╗██╗  ██╗\r\n██╔══██╗██╔══██╗╚══██╔══╝██╔════╝████╗  ██║██╔══██╗██╔══██╗████╗  ██║██║ ██╔╝\r\n██║  ██║███████║   ██║   █████╗  ██╔██╗ ██║██████╔╝███████║██╔██╗ ██║█████╔╝ \r\n██║  ██║██╔══██║   ██║   ██╔══╝  ██║╚██╗██║██╔══██╗██╔══██║██║╚██╗██║██╔═██╗ \r\n██████╔╝██║  ██║   ██║   ███████╗██║ ╚████║██████╔╝██║  ██║██║ ╚████║██║  ██╗\r\n╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝";
            string[] options = { "Suchen", "Daten Erweitern", "Zurück"};
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            bool EinspeicherVal = false;

            if (selectedIndex == 0)
            {
                Console.Clear();
                EinspeicherVal = false;
            }
            else if (selectedIndex == 1)
            {
                Console.Clear();
                EinspeicherVal = true;
            }
            else if (selectedIndex == 2)
            {
                Console.Clear();
                Intro();
            }

            while (EinspeicherVal)
            {
                string[] Einspeichern = new string[Zeilen.Length + 1];
                Count = 0;
                foreach (string zeile in Zeilen)
                {
                    Einspeichern[Count] = zeile;
                    Count++;
                }

                Temp = new string[6];

                Console.Clear();

                Console.WriteLine("ok geben sie die daten ein: ");
                Console.Write("Zuerst die unterordnung \r\n>>> ");
                Temp[0] = Console.ReadLine();
                Console.Write("Jetzt das Tier \r\n>>> ");
                Temp[1] = Console.ReadLine();
                Console.Write("Jetzt das Erwartete Alter \r\n>>> ");
                Temp[2] = Console.ReadLine();
                Console.Write("Jetzt die Population \r\n>>> ");
                Temp[3] = Console.ReadLine();
                Console.Write("Jetzt die Nahrung \r\n>>> ");
                Temp[4] = Console.ReadLine();
                Console.Write("Jetzt die natürlichen Feinde \r\n>>> ");
                Temp[5] = Console.ReadLine();

                Einspeichern[Einspeichern.Length - 1] = $"{Temp[0]};{Temp[1]};{Temp[2]};{Temp[3]};{Temp[4]};{Temp[5]}";
                Console.WriteLine($"Added Line: {Einspeichern[Einspeichern.Length - 1]}");

                File.WriteAllLines(DateiPfad, Einspeichern);
                Console.WriteLine("Saved!");
                System.Environment.Exit(1);
            }

            Console.WriteLine($"Über welches Tier willst du etwas erfahren? In der Datenbank exestieren momentan {Zeilen.Length} Tiere!");
            string TierInput = Console.ReadLine();

            while (true)
            {
                Count = 0;
                bool temp = false;
                foreach (var TiereTemp in Tier)
                {
                    //Console.WriteLine(tiereTemp.Tier);
                    
                    if (TierInput == TiereTemp)
                    {
                        Console.WriteLine($"Gefunden auf Zeile {Count}");
                        Console.WriteLine($" Unterordnung: {Unterordnung[Count]} \r\n Tier: {Tier[Count]} \r\n Alter: {Erwartetes_Alter[Count]} \r\n Population: {Population[Count]} \r\n Nahrung: {Nahrung[Count]} \r\n Natürliche Feinde: {Natürliche_Feinde[Count]}");
                        temp = true;
                        break;
                    }
                    Count++;

                }
                if (temp == true)
                {
                    break;
                }
                Console.WriteLine("Tier wurde nicht gefunden haben sie es richtig geschrieben? y | n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    Console.WriteLine("Dieses Tier exestiert nicht in der Datenbank. Möchten sie es hinzufügen?");
                    input = Console.ReadLine();
                    if (input == "y")
                    {
                        string[] Einspeichern = new string[Zeilen.Length +1];
                        Count = 0;
                        foreach(string zeile in Zeilen)
                        {
                            Einspeichern[Count] = zeile;
                            Count++;
                        }

                        Temp = new string[6];

                        Console.Clear();

                        Console.WriteLine("ok geben sie die daten ein: ");
                        Console.Write("Zuerst die unterordnung \r\n>>> ");
                        Temp[0] = Console.ReadLine();
                        Console.Write("Jetzt das Tier \r\n >>> ");
                        Temp[1] = Console.ReadLine();
                        Console.Write("Jetzt das Erwartete Alter \r\n>>> ");
                        Temp[2] = Console.ReadLine();
                        Console.Write("Jetzt die Population \r\n>>> ");
                        Temp[3] = Console.ReadLine();
                        Console.Write("Jetzt die Nahrung \r\n>>> ");
                        Temp[4] = Console.ReadLine();
                        Console.Write("Jetzt die natürlichen Feinde \r\n>>> ");
                        Temp[5] = Console.ReadLine();

                        Einspeichern[Einspeichern.Length -1] = $"{Temp[0]};{Temp[1]};{Temp[2]};{Temp[3]};{Temp[4]};{Temp[5]}";
                        Console.WriteLine($"Added Line: {Einspeichern[Einspeichern.Length -1]}");

                        File.WriteAllLines(DateiPfad, Einspeichern);
                        Console.WriteLine("Saved!");
                    }
                    else if (input == "n")
                    {
                        Console.Write("schade");
                    }
                    break;
                }
                else if (input == "n")
                {
                    Console.Write("Geben sie das Tier erneut ein: ");
                    TierInput = Console.ReadLine();
                }
                
            }
            
            Console.WriteLine("------------- Ende ---------------");

        }
        static void Quitz()
        {
            string DateiPfad = @"C:\Users\nicla\source\repos\Biologie-Nahrungsnetze-und-Populationsentwicklung\BiologieDatenbankTemp.txt";
            string[] Zeilen = File.ReadAllLines(DateiPfad);

            string[] Unterordnung = new string[Zeilen.Length];
            string[] Tier = new string[Zeilen.Length];
            string[] Erwartetes_Alter = new string[Zeilen.Length];
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
                Erwartetes_Alter[Count] = Temp[2];
                Population[Count] = Temp[3];
                Nahrung[Count] = Temp[4];
                Natürliche_Feinde[Count] = Temp[5];
                Count++;

            }

            string prompt = " ██████╗ ██╗   ██╗██╗████████╗███████╗\r\n██╔═══██╗██║   ██║██║╚══██╔══╝╚══███╔╝\r\n██║   ██║██║   ██║██║   ██║     ███╔╝ \r\n██║▄▄ ██║██║   ██║██║   ██║    ███╔╝  \r\n╚██████╔╝╚██████╔╝██║   ██║   ███████╗\r\n ╚══▀▀═╝  ╚═════╝ ╚═╝   ╚═╝   ╚══════╝";
            string[] options = { "Einfach", "Mittel", "Schwer", "Zurück" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            if (selectedIndex == 0)
            {
                Console.WriteLine("Hier gibts nichts zu sehen :)");
                Random rnd = new Random();
                int num = rnd.Next();
                {
                    Console.WriteLine(rnd.Next(5));
                }
                int[] numbers = { 0, 1, 2, 3, 4, 5 };

            }
        
            else if (selectedIndex == 1)
            {
                Console.WriteLine("Hier gibts nichts zu sehen :)");
                Random rnd = new Random();
                int num = rnd.Next();
                {
                    Console.WriteLine(rnd.Next(5));
                }
            }
            else if (selectedIndex == 2)
            {
                Console.WriteLine("Hier gibts nichts zu sehen :)");
                Random rnd = new Random();
                int num = rnd.Next();
                {
                    Console.WriteLine(rnd.Next(5));
                }
            }
            else if (selectedIndex == 3)
            {
                Console.Clear();
                Auslesen();
            }

            Console.WriteLine("Hier ist die erste Frage");
        }



        static void Populationsdiagramm()
        {




            double x = 5.0; //Anzahl 
            double Beute = 10.0;

            double AblaufZeit = 0;

            double WachstumsRateBeute = 0.09;
            double TodesRateBeute = 0.01;
            
            double WachstumsRateJäger = 0.01;
            double TodesRateJäger = 0.04;

            for (int i = 0; i < 1000; ++i)
      {
                
                double dx = (a * x) - (b * x * y);
                double dy = (c * x * y) - (d * y);
                int dt = 1;

                x = x + dx;
                y = y + dy;
                t = t + dt;
            }

            /*int ShuCounter = 0;
            Console.WriteLine("Geben sie an über welche Zeitspanne das Diagramm laufen soll. ");
            int AblaufZeit = Console.ReadLine();
            Console.WriteLine("Geben sie an über welche Intervale das Diagramm überprüft werden soll. ");
            int Interval = Console.ReadLine();
            Console.WriteLine("Geben sie an wie viel Beute momentan vorhanden ist");
            int Beute = Console.ReadLine();
            Console.WriteLine("Geben sie an wie viele Jäger momentan vorhanden sind");
            int Jäger = Console.ReadLine();

            while (ShuCounter = 0;)
            {

                Beute / AblaufZeit == Beute



            }*/

        }


    }
}

