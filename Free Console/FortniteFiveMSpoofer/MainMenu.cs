using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Colorful;
using Console = Colorful.Console;
using System.Diagnostics;

namespace FortniteFiveMSpoofer
{
    internal class MainMenu
    {

        public static void Menu()
        {
            for(; ; ) 
            { 
               Console.Clear();
               WriteLogo();
               Say("1", "Here You Can Add What You Want To Use (FX Spoofer & Token Grabber)");
               Say("2", "Info");
               Say("3", "Discord Server");
               Say("4", "Quit");
               string option = Console.ReadLine();
               if(option == "1")
               {
                    //Here You Can Add What You Want To Use
               }
                else if(option == "2")
               {
                    Console.Clear();
                    WriteLogo();
                    Console.WriteLine("Add You Info Here", Color.White);
                    Console.ReadKey(true);
               }
               else if (option == "3")
               {
                    OpenUrl("Add You Link Here");
                    Console.Clear();
                    WriteLogo();
                    Console.WriteLine("I opened the discord invite!\nPress any key to continue...", Color.BlueViolet);
                    Console.ReadKey(true);
               }
               else if(option == "4")
               {
                    // Quti
               }
               else
               {
                   Console.WriteLine("Error! Please choose a valid option!");
                   Thread.Sleep(1500);
               }
            }
        }


        public static void OpenUrl(string url)
        {
            if (!url.Contains("://")) url = "https://" + url;
            Process.Start("explorer", url);
        }


        public static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.BlueViolet);
            Console.WriteLine("] " + message);
        }
       

        public static void WriteLogo()
        {
            string logo = @"  _    _                      
 | |  | |                     
 | |__| |   ___   _ __    ___ 
 |  __  |  / _ \ | '__|  / _ \
 | |  | | |  __/ | |    |  __/
 |_|  |_|  \___| |_|     \___|                                                                                                  
";

            Console.WriteLine(logo, Color.BlueViolet);
        }
    }
}