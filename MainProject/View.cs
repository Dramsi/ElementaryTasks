using System;

namespace MainProject
{
    class View
    {
        public void ViewMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"    Select the program and enter the corresponding number:

1 - NumberSequenceApp
2 - DecodingNumberApp
3 - LuckyTicketsApp
");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
