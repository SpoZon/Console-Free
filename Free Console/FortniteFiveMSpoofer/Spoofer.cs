using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Colorful;
using Console = Colorful.Console;
using System.Diagnostics;

namespace FortniteFiveMSpoofer
{
    internal class Spoofer
    {
        public static void Menu()
        {
            for (; ; )
            {
                Console.Clear();
                WriteLogo();
                Say("1", "Fortnite Spoofer");
                Say("2", "FiveM Spoofer");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    // Go to Spoofer
                }
                else if (option == "2")
                {
                    // Go to Info
                }

                else
                {
                    Console.WriteLine("Error! Please choose a valid option!");
                    Thread.Sleep(1500);
                }
            }
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        public static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.BlueViolet);
            Console.WriteLine("] " + message);
        }


        public static void WriteLogo()
        {
            string logo = @"  _    _                             _____   _                      _   
 | |  | |                           / ____| | |                    | |  
 | |__| |   ___     __ _  __  __   | |      | |__     ___    __ _  | |_ 
 |  __  |  / _ \   / _` | \ \/ /   | |      | '_ \   / _ \  / _` | | __|
 | |  | | | (_) | | (_| |  >  <    | |____  | | | | |  __/ | (_| | | |_ 
 |_|  |_|  \___/   \__,_| /_/\_\    \_____| |_| |_|  \___|  \__,_|  \__|
                                                                        
                                                                        
";

            Console.WriteLine(logo, Color.BlueViolet);
        }
    }
}
