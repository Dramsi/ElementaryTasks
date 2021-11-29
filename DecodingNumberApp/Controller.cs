using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    class Controller
    {
        public void Run()
        {
            bool check;
            do
            {
                View view = new View();
                view.GetStringNumber(ConvertNumber(view.SetIntNumber()));
                check = view.RetryMessage();
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
        public string ConvertNumber(int number)
        {
            if (number >= -1 && number <= 19)
                return new TranslationDictionary().numberDictionary[number];
            if (number >= 20 && number <= 999)
            {
                int remainderOfDivision = number % GetRank(number);
                int numberWithoutRemainder = number - remainderOfDivision;
                if (remainderOfDivision != 0)
                    return new TranslationDictionary().numberDictionary[numberWithoutRemainder] + " " + ConvertNumber(remainderOfDivision);
                else
                    return new TranslationDictionary().numberDictionary[numberWithoutRemainder];
            }
            if (number >= 1000)
            {
                int remainderOfDivision = number % GetRank(number);
                int numberWithoutRemainder = (number - remainderOfDivision) / GetRank(number);
                if (remainderOfDivision != 0)
                    return ConvertNumber(numberWithoutRemainder) + GetNumericName(number, numberWithoutRemainder) + ConvertNumber(remainderOfDivision);
                else
                    return ConvertNumber(numberWithoutRemainder) + GetNumericName(number, numberWithoutRemainder);
            }
            return null;
        }
        public string GetNumericName(int number, int numberWithoutRemainder)
        {
            if (GetLengthNumber(number) >= 4 && GetLengthNumber(number) <= 6)
            {
                return " тысяча ";
            }
            if (GetLengthNumber(number) >= 7 && GetLengthNumber(number) <= 9)
            {
                return " миллион ";
            }
            if (GetLengthNumber(number) >= 10 && GetLengthNumber(number) <= 12)
            {
                return " миллиард ";
            }
            return " _ ";
        }
        public int GetRank(int number)
        {
            return new TranslationDictionary().numberRank[GetLengthNumber(number)];
        }
        public int GetLengthNumber(int number)
        {
            return Convert.ToString(number).Length;
        }

    }
}
