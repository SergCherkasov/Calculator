﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface.UserInterface ui = new UserInterface.UserInterface();

            ui.Calculate();
        }
    }
}