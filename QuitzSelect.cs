using System;
using System.Collections.Generic;
using System.Text;

namespace NahrungsnetzAuftrag
{
    internal class QuitzSelect
    {
        ConsoleColor background = Console.BackgroundColor;
        ConsoleColor foreground = Console.ForegroundColor;

        private int selectedAwnser;
        private string[] Options;
        private string Prompt;

        public QuitzSelect(string frage, string[] multiSelect)
        {

            Prompt = frage;
            Options = multiSelect;
            selectedAwnser = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            Console.WriteLine("wieso?");
            for (int i = 0; i < Options.Length; i++)
            {

                string currentOption = Options[i];
                string prefix;
                if (i == selectedAwnser)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }


                Console.WriteLine($" {prefix} << {currentOption} >>");

            }
            Console.ResetColor();

        }


        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {

                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                //Update selectedIndex based on arrow keys.
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    selectedAwnser--;
                    if (selectedAwnser == -1)
                    {
                        selectedAwnser = Options.Length - 1;
                        
                    }
                    
                        
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedAwnser++;
                    if (selectedAwnser == Options.Length)
                    {

                        selectedAwnser = 0;
                    }



                }
            } while (keyPressed != ConsoleKey.Enter);
             

            return selectedAwnser;
        }

    }
}
