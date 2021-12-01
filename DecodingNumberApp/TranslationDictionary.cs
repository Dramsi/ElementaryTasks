using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    class TranslationDictionary
    {
        public string format = "000 000 000 000 000 000 000";

        public char[] naturalUnits = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Dictionary<int, string> numberDictionary = new Dictionary<int, string>()
        {
            { 0, "ноль" },
            { 1, "один" },
            { 2, "два" },
            { 3, "три" },
            { 4, "четыре" },
            { 5, "пять" },
            { 6, "шесть" },
            { 7, "семь" },
            { 8, "восемь" },
            { 9, "девять" },
            { 10, "десять" },
            { 11, "одинадцать" },
            { 12, "двенадцать" },
            { 13, "тринадцать" },
            { 14, "четырнадцать" },
            { 15, "пятнадцать" },
            { 16, "шестнадцать" },
            { 17, "семнадцать" },
            { 18, "восемнадцать" },
            { 19, "девятнадцать" },
            { 20, "двадцать" },
            { 30, "тридцать" },
            { 40, "сорок" },
            { 50, "пятьдесят" },
            { 60, "шестьдесят" },
            { 70, "семьдесят" },
            { 80, "восемьдесят" },
            { 90, "девяносто" },
            { 100, "сто" },
            { 200, "двести" },
            { 300, "триста" },
            { 400, "четыреста" },
            { 500, "пятьсот" },
            { 600, "шестьсот" },
            { 700, "семьсот" },
            { 800, "восемьсот" },
            { 900, "девятьсот" }
        };
        public Dictionary<int, int> numberRank = new Dictionary<int, int>()
        {
            { 2, 10 },
            { 3, 100 }
        };
        public Dictionary<int, string> valueRank = new Dictionary<int, string>()
        {
            { 1, "" },
            { 2, " тысяч " },
            { 3, " миллионов " },
            { 4, " миллиардов " },
            { 5, " биллионов " },
            { 6, " биллиардов " },
            { 7, " триллионов " }
        };






        // TODO: убрать неиспользуемые на данный момент

        public Dictionary<int, string> thousandNamber = new Dictionary<int, string>()
        {
            { 1, "одна" },
            { 2, "две" }
        };
        public Dictionary<int, string> thousandName = new Dictionary<int, string>()
        {
            { 1, " тысяча " },
            { 2, " тысячи " },
            { 3, " тысяч " }
        };
        public Dictionary<int, string> millionNamber = new Dictionary<int, string>()
        {
            { 1, "один" }
        };
        public Dictionary<int, string> millionName = new Dictionary<int, string>()
        {
            { 1, " миллион " },
            { 2, " миллиона " },
            { 3, " миллионов " }
        };
        public Dictionary<int, string> billionName = new Dictionary<int, string>()
        {
            { 1, " миллиард " },
            { 2, " миллиарда " },
            { 3, " миллиардов " }
        };
        public Dictionary<int, string> trillionName = new Dictionary<int, string>()
        {
            { 1, " биллион " },
            { 2, " биллиона " },
            { 3, " биллионов " }
        };
        public Dictionary<int, string> quadrillionName = new Dictionary<int, string>()
        {
            { 1, " биллиард " },
            { 2, " биллиарда " },
            { 3, " биллиардов " }
        };
        public Dictionary<int, string> quintillionName = new Dictionary<int, string>()
        {
            { 1, " триллион " },
            { 2, " триллиона " },
            { 3, " триллионов " }
        };
    }
}
