using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    class TranslationDictionary
    {
        public Dictionary<int, string> numberDictionary = new Dictionary<int, string>()
        {
            { -1, "" },
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
            { 3, 100 },
            { 4, 1000 },
            { 5, 1000 },
            { 6, 1000 },
            { 7, 1000000 },
            { 8, 1000000 },
            { 9, 1000000 },
            { 10, 10000000 },
            { 11, 10000000 },
            { 12, 10000000 }
        };
        public Dictionary<int, string> thousandName = new Dictionary<int, string>()
        {
            { 1, " тысяча " },
            { 2, " тысячи " },
            { 3, " тысяч " }
        };
        public Dictionary<int, string> thousandNamber = new Dictionary<int, string>()
        {
            { 1, "одна" },
            { 2, "две" }
        };
        public Dictionary<int, string> millionName = new Dictionary<int, string>()
        {
            { 1, " миллион " },
            { 2, " миллиона " },
            { 3, " миллионов " }
        };
        public Dictionary<int, string> millionNamber = new Dictionary<int, string>()
        {
            { 1, "один" }
        };
        public Dictionary<int, string> billionName = new Dictionary<int, string>()
        {
            { 1, " миллиард " },
            { 2, " миллиарда " },
            { 3, " миллиардов " }
        };
    }
}
