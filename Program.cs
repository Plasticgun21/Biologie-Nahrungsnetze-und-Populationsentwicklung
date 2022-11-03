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
            //Intro();
            Auslesen();
        }
        static void Intro()
        {
            /*Console.WriteLine("Willkommen im Biologie Menu");

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if  (keyPressed.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Du hast Enter gedrückt");
                //Auslesen();
            }

            else if (keyPressed.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Du hast die linke Pfeiltaste gedrückt");
                //Auslesen();
            }

            else 
            {
                Console.WriteLine("andere Taste gedrückt");
                
            }*/

            string prompt = "Willkommen zum scuffed Biologie Menu";
            string[] options = { "Datenbank","Quiz","Diagramm" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            Console.WriteLine("Drücke irgendeine Taste um das Menu zu schliessen.");
            Console.ReadKey(true);



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
                    Console.WriteLine("Möchten sie es hinzufügen?");
                    input = Console.ReadLine();
                    if (input == "y")
                    {
                        string[] Einspeichern = new string[Zeilen.Length + 1];
                        Count = 0;
                        foreach(string zeile in Zeilen)
                        {
                            Einspeichern[Count] = zeile;
                            Count++;
                        }

                        Temp = new string[6];

                        Console.WriteLine("ok geben sie die daten ein: ");
                        Console.Write("Zuerst die unterordnung \r\n >>> ");
                        Temp[0] = Console.ReadLine();
                        Console.Write("Jetzt das Tier \r\n >>> ");
                        Temp[1] = Console.ReadLine();
                        Console.Write("Jetzt das Erwartete Alter \r\n >>> ");
                        Temp[2] = Console.ReadLine();
                        Console.Write("Jetzt die Population \r\n >>> ");
                        Temp[3] = Console.ReadLine();
                        Console.Write("Jetzt die Nahrung \r\n >>> ");
                        Temp[4] = Console.ReadLine();
                        Console.Write("Jetzt die natürlichen Feinde \r\n >>> ");
                        Temp[5] = Console.ReadLine();

                        Console.WriteLine($"{Temp[0]}; {Temp[2]}; {Temp[3]}; {Temp[4]}; {Temp[5]}");
                        Console.WriteLine($"{Einspeichern[97]}, true du german");
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
                //--------- Janaret ---------------
               

                Console.WriteLine("Wilkommen beim Quiz");
                Console.WriteLine("Wählen Sie bitte eine Schwierigkeitsstufe");


                Console.WriteLine("Hier ist die erste Frage");


                //--------- Janaret ---------------
            }



            Console.WriteLine("------------- Ende ---------------");

            foreach (string z in Tier)
            {
                //Console.WriteLine(z);
            }

        }
        
    }
}

