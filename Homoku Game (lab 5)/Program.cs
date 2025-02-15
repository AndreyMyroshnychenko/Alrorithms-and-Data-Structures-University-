﻿using System;

namespace ПА_Лаб._5
{
    class Program
    {

        static void Main(string[] args)
        {
            LocalStorage.InitializeSettings();
            LocalStorage.InitializeMoves();
            Menu.Initialize();
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        public static void Initialize()
        {
            Console.Clear();
            try
            {
                Console.CursorSize = 100;
            }
            catch (PlatformNotSupportedException)
            {

            }
            Console.CancelKeyPress += delegate
            {
                ExitGame();
            };
        }


        public static void ExitGame()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
