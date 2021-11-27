using System;

namespace MainProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "ElementaryTasks - Anastasiia";
            ConsoleKeyInfo key;
            View view = new View();
            int state = 1;
            view.ViewMenu(state);
            
            do
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    state = 2;
                    view.ViewMenu(state);
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    state = 1;
                    view.ViewMenu(state);
                }
                if (key.Key == ConsoleKey.Enter && state == 1)
                {
                    view.ViewProgramm(1);
                }
                if (key.Key == ConsoleKey.Enter && state == 2)
                {
                    view.ViewProgramm(2);
                }
                if (key.Key == ConsoleKey.Backspace && state == 1)
                {
                    view.ViewMenu(state);
                }
                if (key.Key == ConsoleKey.Backspace && state == 2)
                {
                    view.ViewMenu(state);
                }
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
