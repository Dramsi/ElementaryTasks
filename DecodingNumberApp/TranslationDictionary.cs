using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    class TranslationDictionary
    {
        public Dictionary<ulong, string> numberDictionary = new Dictionary<ulong, string>()
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
        public Dictionary<int, ulong> numberRank = new Dictionary<int, ulong>()
        {
            { 2, 10 },
            { 3, 100 },
            { 4, 1000 },
            { 5, 1000 },
            { 6, 1000 },
            { 7, 1000000 },
            { 8, 1000000 },
            { 9, 1000000 },
            { 10, 1000000000 },
            { 11, 1000000000 },
            { 12, 1000000000 },
            { 13, 1000000000000 },
            { 14, 1000000000000 },
            { 15, 1000000000000 },
            { 16, 1000000000000000 },
            { 17, 1000000000000000 },
            { 18, 1000000000000000 },
            { 19, 1000000000000000000 },
            { 20, 1000000000000000000 },
            { 21, 1000000000000000000 }
        };
        public Dictionary<ulong, string> thousandNamber = new Dictionary<ulong, string>()
        {
            { 1, "одна" },
            { 2, "две" }
        };
        public Dictionary<ulong, string> thousandName = new Dictionary<ulong, string>()
        {
            { 1, " тысяча " },
            { 2, " тысячи " },
            { 3, " тысяч " }
        };
        public Dictionary<ulong, string> millionNamber = new Dictionary<ulong, string>()
        {
            { 1, "один" }
        };
        public Dictionary<ulong, string> millionName = new Dictionary<ulong, string>()
        {
            { 1, " миллион " },
            { 2, " миллиона " },
            { 3, " миллионов " }
        };
        public Dictionary<ulong, string> billionName = new Dictionary<ulong, string>()
        {
            { 1, " миллиард " },
            { 2, " миллиарда " },
            { 3, " миллиардов " }
        };
        public Dictionary<ulong, string> trillionName = new Dictionary<ulong, string>()
        {
            { 1, " биллион " },
            { 2, " биллиона " },
            { 3, " биллионов " }
        };
        public Dictionary<ulong, string> quadrillionName = new Dictionary<ulong, string>()
        {
            { 1, " биллиард " },
            { 2, " биллиарда " },
            { 3, " биллиардов " }
        };
        public Dictionary<ulong, string> quintillionName = new Dictionary<ulong, string>()
        {
            { 1, " триллион " },
            { 2, " триллиона " },
            { 3, " триллионов " }
        };
    }
}
