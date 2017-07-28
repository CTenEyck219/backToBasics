﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set up Console UI
            Console.Title = "Reason for learning c#";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("This is the first of many c#" +
                "Console Apps that I will be creating.\n");
            Console.WriteLine("I am on my way to learning c# on the basis of " +
                "learning Database Integration along with " +
                "other customer facing application to integrate " +
                "with backend infastructure.");
            Console.BackgroundColor = ConsoleColor.Black;

            //Wait for user to press key enter
            Console.ReadLine();

            MessageBox.Show("That's it for now. Come back tomorrow night for more!");

        }
    }
}
