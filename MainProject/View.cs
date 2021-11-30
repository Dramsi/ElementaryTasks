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
                    Console.WriteLine("Number in alphabetical format");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sequence of numbers");
                    Console.WriteLine("\nPress Esc to close the program.");
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press ▲ or ▼ on the keyboard to interact with the menu.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Number in alphabetical format");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sequence of numbers");
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
                    Console.WriteLine("You selected (DecodingNumberApp).\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    new DecodingNumberApp.Controller().Run();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Press Backspace to return to the menu.\n");
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You selected (NumberSequenceApp).\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    new NumberSequenceApp.Controller().Run();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press Backspace to return to the menu.\n");
                    break;
            }
        }
    }
}
