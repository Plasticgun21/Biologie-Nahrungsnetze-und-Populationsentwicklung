using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        static void Selector(string typ)
        {

            if(typ == "Intro")
            {
                Intro();
            }
            else if (typ == "Auslesen")
            {
                Auslesen();
            }
            else if (typ == "Quiz")
            {
                Quitz();
            }
        }

        static void Intro()
        {
            Console.WriteLine("Willkommen im Biologie Menu");
            Console.WriteLine("Sie können mit den Pfeiltasten im Biologie Menu navigieren");
            Thread.Sleep(2000);
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

            string prompt = " ██████╗ ██╗   ██╗██╗███████╗\r\n██╔═══██╗██║   ██║██║╚══███╔╝\r\n██║   ██║██║   ██║██║  ███╔╝ \r\n██║▄▄ ██║██║   ██║██║ ███╔╝  \r\n╚██████╔╝╚██████╔╝██║███████╗\r\n ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝";
            string[] options = { "Einfach", "Mittel", "Schwer", "Zurück" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            Random rnd = new Random();

            string Antworten = null;
            int Punktzahl = 0;
            int Fragezahl = 0;
            int Frage = 0;
            int optionRight = 0;
            string[] Letters = { "A", "B", "C", "D" };
            int Nahrungsnetz = 0;
            int AntwZuf = 0;
            int AnzRunden = 1;

            if (selectedIndex == 0)
            {
                Console.WriteLine("Sie haben Einfach gewählt");
                Console.Write("Wie viele runden möchten sie Spielen? \r\n>>>");
                AnzRunden = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < AnzRunden; i++)
                {
                    Frage = rnd.Next(0, 5);
                    switch (Frage)
                    {

                        case 0:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 1);
                            AntwZuf = rnd.Next(Zeilen.Length);
                            if (optionRight == 0)
                            {
                                prompt = $"Ist ein*e {Tier[Nahrungsnetz]} der Unterordnung von {Unterordnung[Nahrungsnetz]}?";
                            }
                            else
                            {
                                prompt = $"Ist ein*e {Tier[Nahrungsnetz]} der Unterordnung von {Unterordnung[AntwZuf]}?";
                            }
                            options[0] = "Ja";
                            options[1] = "Nein";

                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;

                        case 1:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 1);
                            AntwZuf = rnd.Next(Zeilen.Length);

                            if (optionRight == 0)
                            {
                                prompt = $"wird ein*e {Tier[Nahrungsnetz]} ungefähr {Erwartetes_Alter[Nahrungsnetz]} alt?";
                            }
                            else
                            {
                                prompt = $"wird ein*e {Tier[Nahrungsnetz]} ungefähr {Erwartetes_Alter[AntwZuf]} alt?";
                            }
                            options[0] = "Ja";
                            options[1] = "Nein";

                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 2:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 1);
                            AntwZuf = rnd.Next(Zeilen.Length);

                            if (optionRight == 0)
                            {
                                prompt = $"Ist die ungefähre Population von {Tier[Nahrungsnetz]} {Population[Nahrungsnetz]}?";
                            }
                            else
                            {
                                prompt = $"Ist die ungefähre Population von {Tier[Nahrungsnetz]} {Population[AntwZuf]}?";
                            }
                            options[0] = "Ja";
                            options[1] = "Nein";

                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 3:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 1);
                            AntwZuf = rnd.Next(Zeilen.Length);

                            if (optionRight == 0)
                            {
                                prompt = $"Isst ein*e {Tier[Nahrungsnetz]} {Nahrung[Nahrungsnetz]}?";
                            }
                            else
                            {
                                prompt = $"Isst ein*e {Tier[Nahrungsnetz]} {Nahrung[AntwZuf]}?";
                            }
                            options[0] = "Ja";
                            options[1] = "Nein";

                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 4:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 1);
                            AntwZuf = rnd.Next(Zeilen.Length);

                            if (optionRight == 0)
                            {
                                prompt = $"Sind die Natürliche Feinde der {Tier[Nahrungsnetz]} {Natürliche_Feinde[Nahrungsnetz]}?";
                            }
                            else
                            {
                                prompt = $"Sind die Natürliche Feinde der {Tier[Nahrungsnetz]} {Natürliche_Feinde[AntwZuf]}?";
                            }
                            options[0] = "Ja";
                            options[1] = "Nein";

                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 5:
                            Console.WriteLine();
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 1);
                            AntwZuf = rnd.Next(Zeilen.Length);

                            if (optionRight == 0)
                            {
                                prompt = $"Was ist ein {Tier[Nahrungsnetz]}?";
                            }
                            else
                            {
                                prompt = $"Was ist ein {Tier[AntwZuf]}?";
                            }
                            options[0] = "Ja";
                            options[1] = "Nein";

                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;

                    }
                }
                Console.WriteLine($"Sie haben {Punktzahl} von {Fragezahl} richtig beantwortet");
            }

            else if (selectedIndex == 1)
            {
                Console.WriteLine("Sie haben Mittel gewählt");
                Console.Write("Wie viele runden möchten sie Spielen? \r\n>>>");
                AnzRunden = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < AnzRunden; i++)
                {
                    
                    Frage = rnd.Next(0, 4);
                    switch (Frage)
                    {
                        case 0:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 3);
                            prompt = $"Wie hiesst die Unterordnung eines {Tier[Nahrungsnetz]}?";

                            AntwZuf = rnd.Next(0, 3);
                            options[0] = $"(A) {Unterordnung[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[1] = $"(B) {Unterordnung[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[2] = $"(C) {Unterordnung[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[3] = $"(D) {Unterordnung[AntwZuf]}";

                            options[optionRight] = $"({Letters[optionRight]}) {Unterordnung[Nahrungsnetz]}";
                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Supa");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Niss gut");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }

                            break;
                        case 1:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 3);
                            prompt = $"Wie alt wird ein*e {Tier[Nahrungsnetz]}?";

                            AntwZuf = rnd.Next(0, 3);
                            options[0] = $"(A) {Erwartetes_Alter[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[1] = $"(B) {Erwartetes_Alter[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[2] = $"(C) {Erwartetes_Alter[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[3] = $"(D) {Erwartetes_Alter[AntwZuf]}";

                            options[optionRight] = $"({Letters[optionRight]}) {Erwartetes_Alter[Nahrungsnetz]}";
                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Supa");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Niss gut");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }

                            break;
                        case 2:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 3);
                            prompt = $"Was ist die ungefähre Population von {Tier[Nahrungsnetz]}?";

                            AntwZuf = rnd.Next(0, 3);
                            options[0] = $"(A) {Population[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[1] = $"(B) {Population[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[2] = $"(C) {Population[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[3] = $"(D) {Population[AntwZuf]}";

                            options[optionRight] = $"({Letters[optionRight]}) {Population[Nahrungsnetz]}";
                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Supa");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Niss gut");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }

                            break;
                        case 3:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 3);
                            prompt = $"Was sind die Natürliche Feinde der {Tier[Nahrungsnetz]}?";

                            AntwZuf = rnd.Next(0, 3);
                            options[0] = $"(A) {Natürliche_Feinde[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[1] = $"(B) {Natürliche_Feinde[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[2] = $"(C) {Natürliche_Feinde[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[3] = $"(D) {Natürliche_Feinde[AntwZuf]}";

                            options[optionRight] = $"({Letters[optionRight]}) {Natürliche_Feinde[Nahrungsnetz]}";
                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Supa");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Niss gut");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }

                            break;
                        case 4:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            optionRight = rnd.Next(0, 3);
                            prompt = $"Was ist ein {Tier[Nahrungsnetz]}?";
                            AntwZuf = rnd.Next(0, 3);
                            options[0] = $"(A) {Unterordnung[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[1] = $"(B) {Unterordnung[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[2] = $"(C) {Unterordnung[AntwZuf]}";
                            AntwZuf = rnd.Next(0, 3);
                            options[3] = $"(D) {Unterordnung[AntwZuf]}";

                            options[optionRight] = $"({Letters[optionRight]}) {Unterordnung[Nahrungsnetz]}";
                            mainMenu = new Menu(prompt, options);
                            selectedIndex = mainMenu.Run();

                            if (selectedIndex == optionRight)
                            {
                                Console.WriteLine("Supa");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Niss gut");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }

                            break;

                    }
                }
                Console.WriteLine($"Sie haben {Punktzahl} von {Fragezahl} richtig beantwortet");
            }
            else if (selectedIndex == 2)
            {
                Console.Clear();
                Console.WriteLine("Sie haben Mittel gewählt");
                Console.Write("Wie viele runden möchten sie Spielen? \r\n>>>");
                AnzRunden = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                for (int i = 0; i < AnzRunden; i++)
                {
                    Console.Clear();
                    Frage = rnd.Next(0, 5);
                    Nahrungsnetz = rnd.Next(Zeilen.Length);
                    switch (Frage)
                    {

                        case 0:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            Console.Write($"Wie hiesst die Unterordnung eines {Tier[Nahrungsnetz]}?\r\n>>>");
                            Antworten = Convert.ToString(Console.ReadLine());
                            if (Antworten == Tier[Nahrungsnetz])
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 1:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            Console.Write($"Wie alt wird ein*e {Tier[Nahrungsnetz]}?\r\n>>>");
                            Antworten = Convert.ToString(Console.ReadLine());
                            if (Antworten == Tier[Nahrungsnetz])
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 2:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            Console.Write($"Was ist die ungefähre Population von {Tier[Nahrungsnetz]}?\r\n>>>");
                            Antworten = Convert.ToString(Console.ReadLine());
                            if (Antworten == Tier[Nahrungsnetz])
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 3:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            Console.Write($"Was sind die Natürliche Feinde der {Tier[Nahrungsnetz]}?\r\n>>>");
                            Antworten = Convert.ToString(Console.ReadLine());
                            if (Antworten == Tier[Nahrungsnetz])
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;
                        case 4:
                            Nahrungsnetz = rnd.Next(Zeilen.Length);
                            Console.Write($"Was sind die Natürliche Feinde der {Tier[Nahrungsnetz]}?\r\n>>>");
                            Antworten = Convert.ToString(Console.ReadLine());
                            if (Antworten == Tier[Nahrungsnetz])
                            {
                                Console.WriteLine("Gut gemacht, Sie haben die Antwort korreckt.");
                                Punktzahl++;
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Schade, Sie haben leider falsch geantwortet.");
                                Fragezahl++;
                                Thread.Sleep(1000);
                            }
                            break;

                    }
                }
                Console.WriteLine($"Sie haben {Punktzahl} von {Fragezahl} richtig beantwortet");

            }

            else if (selectedIndex == 3)
            {
                Console.Clear();
                Intro();
            }

            
        }


        
        static void Populationsdiagramm()
        {
            double x = 10; //Anzahl Beute im System
            double y = 5; //Anzahl Jäger im System
            double a = 0.09; //Wachstumsrate von der Beute
            double b = 0.01; //Todesrate von der Beute
            double c = 0.01; //Wachstumsrate von den Jägern
            double d = 0.05; //Todesrate von den Jägern
            int t = 100; //Zeitspanne von der Simulation
            /*
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
            */

            Console.WriteLine($"Beute = {x} Jäger = {y}");
            Console.WriteLine($"Beute Wachstum = {a} Todesrate Beute = {b}");
            Console.WriteLine($"Jäger Wachstum = {c} Todesrate Jäger = {d}");
            Console.WriteLine("\ntime" + "\t" + "Beute" + "\t" + "Jäger");


            /*Console.WriteLine("Beute = " + x.ToString("F1") + "  Jäger = " + y.ToString("F1"));
            Console.WriteLine("Beute Wachstum     = " + a.ToString("F3") + " Todesrate Beute     = " + b.ToString("F3"));
            Console.WriteLine("Jäger Wachstum = " + c.ToString("F3") + " Todesrate Jäger = " + d.ToString("F3"));
            Console.WriteLine("\ntime" + "\t" + "Beute" + "\t" + "Jäger");*/

            

            int Time = t;
            int[] NumsTime = new int[Time];
            int[] NumsPreditor = new int[Time];
            int[] NumsHunter = new int[Time];
            int Counter = 0;
            int dt = 1;
            for (int i = 0; i < Time; ++i)
            {
                NumsTime[Counter] = t;
                NumsPreditor[Counter] = Convert.ToInt32(Math.Round(x, 0, MidpointRounding.ToEven));
                NumsHunter[Counter] = Convert.ToInt32(Math.Round(y, 0, MidpointRounding.ToEven));

                Console.WriteLine($"{t} \t {Math.Round(x, 0, MidpointRounding.ToEven)} \t {Math.Round(y, 0, MidpointRounding.ToEven)}");

                double dx = (a * x) - (b * x * y);
                double dy = (c * x * y) - (d * y);
                

                x = x + dx;
                y = y + dy;
                t = t + dt;



                Counter++;
            }
            Counter = 0;

            var chartList = new List<Point>
            {/*
                new Point(Convert.ToInt32(Math.Round(xVal[0], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[0], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[1], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[1], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[2], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[2], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[3], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[3], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[4], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[4], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[5], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[5], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[6], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[6], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[7], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[7], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[8], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[8], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[9], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[9], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[10], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[10], 0, MidpointRounding.ToEven))),
                new Point(Convert.ToInt32(Math.Round(xVal[11], 0, MidpointRounding.ToEven)), Convert.ToInt32(Math.Round(yVal[11], 0, MidpointRounding.ToEven))),
                */
                new Point(NumsPreditor[0], NumsHunter[0]),
                new Point(NumsPreditor[1], NumsHunter[1]),
                new Point(NumsPreditor[2], NumsHunter[2]),
                new Point(NumsPreditor[3], NumsHunter[3]),
                new Point(NumsPreditor[4], NumsHunter[4]),
                new Point(NumsPreditor[5], NumsHunter[5]),
                new Point(NumsPreditor[6], NumsHunter[6]),
                new Point(NumsPreditor[7], NumsHunter[7]),
                new Point(NumsPreditor[8], NumsHunter[8])
            };

            
           



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

