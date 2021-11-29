using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class View
    {
        public void ViewMenu(int state)
        {
            Console.Clear();
            switch (state)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press ▲ or ▼ on the keyboard to interact with the menu.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Number to write");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Numerical sequence");
                    Console.WriteLine("\nPress Esc to close the program.");
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press ▲ or ▼ on the keyboard to interact with the menu.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Number to write");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numerical sequence");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress Esc to close the program.");
                    break;
            }
        }
        public void ViewProgramm(int state)
        {
            Console.Clear();
            switch (state)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You selected (Number to write).\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    new DecodingNumberApp.Controller().Run();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Press Backspace to return to the menu.\n");
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You selected (Numerical sequence).\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    new NumberSequenceApp.Controller().Run();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press Backspace to return to the menu.\n");
                    break;
            }
        }
    }
}
