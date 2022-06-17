using FortniteFiveMSpoofer;
using System;

namespace SimpleMenu
{
    class login
    {
        static void Main(string[] args)
        {
            Console.Title = "login";
            // login
            MainMenu.WriteLogo();
            Console.WriteLine("Welcome Back!");
            Console.ReadKey(true);
            MainMenu.Menu();
        }

    }
}