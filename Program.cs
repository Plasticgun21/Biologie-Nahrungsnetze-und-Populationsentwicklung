﻿using System;
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
            string[] options = { "Datenbank", "Quiz", "Diagramm" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            if (selectedIndex == 0)
            {
                Console.Clear();
                Auslesen();
            }
            else if (selectedIndex == 1)
            {
                Console.Clear();
                Quitz();
            }
            else if (selectedIndex == 2)
            {
                Console.Clear();
                Populationsdiagramm();

            }



        }

        static void Auslesen()
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

            string prompt = "██████╗  █████╗ ████████╗███████╗███╗   ██╗██████╗  █████╗ ███╗   ██╗██╗  ██╗\r\n██╔══██╗██╔══██╗╚══██╔══╝██╔════╝████╗  ██║██╔══██╗██╔══██╗████╗  ██║██║ ██╔╝\r\n██║  ██║███████║   ██║   █████╗  ██╔██╗ ██║██████╔╝███████║██╔██╗ ██║█████╔╝ \r\n██║  ██║██╔══██║   ██║   ██╔══╝  ██║╚██╗██║██╔══██╗██╔══██║██║╚██╗██║██╔═██╗ \r\n██████╔╝██║  ██║   ██║   ███████╗██║ ╚████║██████╔╝██║  ██║██║ ╚████║██║  ██╗\r\n╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝";
            string[] options = { "Suchen", "Daten Erweitern", "Zurück" };
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

                        Einspeichern[Einspeichern.Length - 1] = $"{Temp[0]};{Temp[1]};{Temp[2]};{Temp[3]};{Temp[4]};{Temp[5]}";
                        Console.WriteLine($"Added Line: {Einspeichern[Einspeichern.Length - 1]}");

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

            Random rnd = new Random();

            int Frage = rnd.Next(0, 5);
            int Nahrungsnetz = rnd.Next(Zeilen.Length);
            string Antworten = "";
            int Punktzahl = 0;
            int Fragezahl = 0;
            int A;
            int B;
            int C;
            int D;

            if (selectedIndex == 0)
            {

                switch (Frage)
                {

                    case 0:
                        Console.WriteLine($"Ist ein*e {Tier[Nahrungsnetz]} der Unterordnung von {Unterordnung[Nahrungsnetz]}?");
                        Antworten = Convert.ToString(Console.ReadLine());
                        if (Antworten == Tier[Nahrungsnetz])  
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else 
                        {                       
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 1:
                        Console.WriteLine($"Wird ein*e {Tier[Nahrungsnetz]} ungefähr {Erwartetes_Alter[Nahrungsnetz]} alt?");
                        if (Antworten ==  Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {                            
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Ist die ungefähre Population von {Tier[Nahrungsnetz]} {Population[Nahrungsnetz]}?");
                        if (Antworten ==   Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                            }
                        else
                        {                            
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Isst ein*e {Tier[Nahrungsnetz]} {Nahrung[Nahrungsnetz]}?");
                        if (Antworten ==  Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else 
                        {                          
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Sind die Natürliche Feinde der {Tier[Nahrungsnetz]} {Natürliche_Feinde[Nahrungsnetz]}?");
                        if (Antworten ==   Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else 
                        {                            
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Was ist ein {Tier[Nahrungsnetz]}?");
                        if (Antworten ==   Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {                            
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                }

            }

            else if (selectedIndex == 1)
            {
                switch (Frage)
                {

                    case 0:
                        Console.WriteLine($"Ist ein*e {Tier[Nahrungsnetz]} der Unterordnung von {Unterordnung[Nahrungsnetz]}?");
                        Antworten = Console.ReadLine();                       
                        A = 0;
                        B = 1;
                        C = 2;
                        D = 3;
                        Frage = rnd.Next(0, 3);

                        break;
                    case 1:
                        Console.WriteLine($"Wird ein*e {Tier[Nahrungsnetz]} ungefähr {Erwartetes_Alter[Nahrungsnetz]} alt?");
                        if (Antworten == Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Ist die ungefähre Population von {Tier[Nahrungsnetz]} {Population[Nahrungsnetz]}?");
                        if (Antworten == Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Isst ein*e {Tier[Nahrungsnetz]} {Nahrung[Nahrungsnetz]}?");
                        if (Antworten == Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Sind die Natürliche Feinde der {Tier[Nahrungsnetz]} {Natürliche_Feinde[Nahrungsnetz]}?");
                        if (Antworten == Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Was ist ein {Tier[Nahrungsnetz]}?");
                        if (Antworten == Tier[Nahrungsnetz])
                        {
                            Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                            Punktzahl++;
                            Fragezahl++;
                        }
                        else
                        {
                            Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                            Fragezahl++;
                        }
                        break;
                }
            }
            else if (selectedIndex == 2)
            {
                Console.WriteLine("Hier gibts nichts zu sehen :)");
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
            double x = 0; //Anzahl Beute im System
            double y = 0; //Anzahl Jäger im System
            double a = 0; //Wachstumsrate von der Beute
            double b = 0; //Todesrate von der Beute
            double c = 0; //Wachstumsrate von den Jägern
            double d = 0; //Todesrate von den Jägern
            int t = 0; //Zeitspanne von der Simulation

            try
            {
                Console.WriteLine("Bitte Geben sie an wie viel Beute vorhanden ist. ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte Geben sie an wie viele Jäger vorhanden sind. ");
                y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte Geben sie an wie schnell sich die Beute fortpflanzt. ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte Geben sie an wie viel der Beute getötet wird. ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte Geben sie an wie schnell sich die Jäger fortpflanzen. ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte Geben sie an wie viele der Jäger natürlich sterben. ");
                d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bitte Geben sie nun an über wie viele Jahre das Diagramm erstellt werden soll. ");
                t = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Fehler, geben sie eine gültige Zahl ein.");
            }

            Console.WriteLine($"Beute = {x} Jäger = {y}");
            Console.WriteLine($"Beute Wachstum = {a} Todesrate Beute = {b}");
            Console.WriteLine($"Jäger Wachstum = {c} Todesrate Jäger = {d}");
            Console.WriteLine("\ntime" + "\t" + "Beute" + "\t" + "Jäger");


            /*Console.WriteLine("Beute = " + x.ToString("F1") + "  Jäger = " + y.ToString("F1"));
            Console.WriteLine("Beute Wachstum     = " + a.ToString("F3") + " Todesrate Beute     = " + b.ToString("F3"));
            Console.WriteLine("Jäger Wachstum = " + c.ToString("F3") + " Todesrate Jäger = " + d.ToString("F3"));
            Console.WriteLine("\ntime" + "\t" + "Beute" + "\t" + "Jäger");*/
            double dx = 0;
            double dy = 0;
            int Time = t;
            var chartList = new List<Point>();
            int counterDiagramm = 0;
            for (int i = 0; i <= t; ++i)
            {
                Math.Round(x, 0, MidpointRounding.ToEven);
                Math.Round(y, 0, MidpointRounding.ToEven);

                Console.WriteLine($"{t} \t {x} \t {y}");


                dx = (a * x) - (b * x * y);
                dy = (c * x * y) - (d * y);
                int dt = 1;

                x = x + dx;
                y = y + dy;
                t = t + dt;

                new Point(Convert.ToInt32(Math.Round(dx, 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(dy, 0, MidpointRounding.ToEven))); // dx = Anzahl von Beute  dy = Anzahl von den Jägern

                counterDiagramm++;
            }
            /*
            while (counterDiagramm < t)
            {
                new Point(dx, dy); // dx = Anzahl von Beute  dy = Anzahl von den Jägern

                counterDiagramm++;
            } */

            /* new Point(71, 87),
               new Point(72, 87),
               new Point(73, 87),
               new Point(71, 89),
               new Point(25, 66),
               new Point(118, 15),
               new Point(33, 94)  */

            DrawChart(chartList);
            Console.Read();

        }

        public struct Point
        {
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; }
            public int Y { get; }
        }
        public static void DrawChart(List<Point> dict)
        {
            int consoleWidth = 78;
            int consoleHeight = 20;
            int actualConsoleHeight = consoleHeight * 2;
            var minX = dict.Min(c => c.X);
            var minY = dict.Min(c => c.Y);
            var maxX = dict.Max(c => c.X);
            var maxY = dict.Max(c => c.Y);

            Console.WriteLine(maxX);
            // normalize points to new coordinates
            var normalized = dict.
                Select(c => new Point(c.X - minX, c.Y - minY)).
                Select(c => new Point((int)Math.Round((float)(c.X) / (maxX - minX) * (consoleWidth - 1)), (int)Math.Round((float)(c.Y) / (maxY - minY) * (actualConsoleHeight - 1)))).ToArray();
            Func<int, int, bool> IsHit = (hx, hy) =>
            {
                return normalized.Any(c => c.X == hx && c.Y == hy);
            };

            for (int y = actualConsoleHeight - 1; y > 0; y -= 2)
            {
                Console.Write(y == actualConsoleHeight - 1 ? '┌' : '│');
                for (int x = 0; x < consoleWidth; x++)
                {
                    bool hitTop = IsHit(x, y);
                    bool hitBottom = IsHit(x, y - 1);
                    if (hitBottom && hitTop)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write('█');
                    }
                    else if (hitTop)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write('▀');
                    }
                    else if (hitBottom)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write('▀');
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write('▀');
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine('└' + new string('─', (consoleWidth / 2) - 1) + '┴' + new string('─', (consoleWidth / 2) - 1) + '┘');
            Console.Write((dict.Min(x => x.X) + "/" + dict.Min(x => x.Y)).PadRight(consoleWidth / 3));
            Console.Write((dict.Max(x => x.Y) / 2).ToString().PadLeft(consoleWidth / 3 / 2).PadRight(consoleWidth / 3));
            Console.WriteLine(dict.Max(x => x.Y).ToString().PadLeft(consoleWidth / 3));
        }
    }
}

