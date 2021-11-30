using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    public class Controller
    {
        public void Run()
        {
            bool check;
            do
            {
                View view = new View();
                object ob = view.SetLongNumber();
                if (ob != null)
                    view.GetStringNumber(ConvertNumber((ulong)ob));
                check = view.RetryMessage();
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
        private string ConvertNumber(ulong number)
        {
            if (number >= 0 && number <= 19)
                return new TranslationDictionary().numberDictionary[number];
            if (number >= 20 && number <= 999)
            {
                ulong remainderOfDivision = number % GetRank(number);
                ulong numberWithoutRemainder = number - remainderOfDivision;
                if (remainderOfDivision != 0)
                    return new TranslationDictionary().numberDictionary[numberWithoutRemainder] + " " + ConvertNumber(remainderOfDivision);
                else
                    return new TranslationDictionary().numberDictionary[numberWithoutRemainder];
            }
            if (number >= 1000)
            {
                ulong remainderOfDivision = number % GetRank(number);
                ulong numberWithoutRemainder = (number - remainderOfDivision) / GetRank(number);
                if (remainderOfDivision != 0)
                    return GetNumericName(number, numberWithoutRemainder) + ConvertNumber(remainderOfDivision);
                else
                    return GetNumericName(number, numberWithoutRemainder);
            }
            return null;
        }
        private string GetNumericName(ulong number, ulong numberWithoutRemainder)
        {
            if (GetLengthNumber(number) >= 4 && GetLengthNumber(number) <= 6)
                return GetThousandName(numberWithoutRemainder);
            if (GetLengthNumber(number) >= 7 && GetLengthNumber(number) <= 9)
                return GetMillionName(numberWithoutRemainder);
            if (GetLengthNumber(number) >= 10 && GetLengthNumber(number) <= 12)
                return GetBillionName(numberWithoutRemainder);
            if (GetLengthNumber(number) >= 13 && GetLengthNumber(number) <= 15)
                return GetTrillionName(numberWithoutRemainder);
            if (GetLengthNumber(number) >= 16 && GetLengthNumber(number) <= 18)
                return GetQuadrillionName(numberWithoutRemainder);
            if (GetLengthNumber(number) >= 19 && GetLengthNumber(number) <= 21)
                return GetQuintillionName(numberWithoutRemainder);
            return " _ ";
        }
        private string GetThousandName(ulong numberWithoutRemainder)
        {
            if (GetLastNumber(numberWithoutRemainder) == 1 || GetLastNumber(numberWithoutRemainder) == 2)
            {
                if (numberWithoutRemainder == 1 || numberWithoutRemainder == 2)
                    return new TranslationDictionary().thousandNamber[numberWithoutRemainder] + new TranslationDictionary().thousandName[numberWithoutRemainder];
                if (numberWithoutRemainder == 11 || numberWithoutRemainder == 12)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().thousandName[3];
                return ConvertNumber(numberWithoutRemainder - GetLastNumber(numberWithoutRemainder)) + " " + new TranslationDictionary().thousandNamber[GetLastNumber(numberWithoutRemainder)] + new TranslationDictionary().thousandName[GetLastNumber(numberWithoutRemainder)];
            }
            if (GetLastNumber(numberWithoutRemainder) == 3 || GetLastNumber(numberWithoutRemainder) == 4)
            {
                if (numberWithoutRemainder == 13 || numberWithoutRemainder == 14)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().thousandName[3];
                else
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().thousandName[2];
            }
            if (GetLastNumber(numberWithoutRemainder) > 4 || GetLastNumber(numberWithoutRemainder) == 0)
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().thousandName[3];
            return " _ ";
        }
        private string GetMillionName(ulong numberWithoutRemainder)
        {
            if (GetLastNumber(numberWithoutRemainder) == 1)
            {
                if (numberWithoutRemainder == 1)
                    return new TranslationDictionary().millionNamber[numberWithoutRemainder] + new TranslationDictionary().millionName[numberWithoutRemainder];
                if (numberWithoutRemainder == 11)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().millionName[3];
                return ConvertNumber(numberWithoutRemainder - GetLastNumber(numberWithoutRemainder)) + " " + new TranslationDictionary().millionNamber[GetLastNumber(numberWithoutRemainder)] + new TranslationDictionary().millionName[GetLastNumber(numberWithoutRemainder)];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 2 && GetLastNumber(numberWithoutRemainder) <= 4)
            {
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().millionName[2];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 5 || GetLastNumber(numberWithoutRemainder) == 0)
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().millionName[3];
            return " _ ";
        }
        private string GetBillionName(ulong numberWithoutRemainder)
        {
            if (GetLastNumber(numberWithoutRemainder) == 1)
            {
                if (numberWithoutRemainder == 1)
                    return new TranslationDictionary().millionNamber[numberWithoutRemainder] + new TranslationDictionary().billionName[numberWithoutRemainder];
                if (numberWithoutRemainder == 11)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().billionName[3];
                return ConvertNumber(numberWithoutRemainder - GetLastNumber(numberWithoutRemainder)) + " " + new TranslationDictionary().millionNamber[GetLastNumber(numberWithoutRemainder)] + new TranslationDictionary().billionName[GetLastNumber(numberWithoutRemainder)];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 2 && GetLastNumber(numberWithoutRemainder) <= 4)
            {
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().billionName[2];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 5 || GetLastNumber(numberWithoutRemainder) == 0)
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().billionName[3];
            return " _ ";
        }
        private string GetTrillionName(ulong numberWithoutRemainder)
        {
            if (GetLastNumber(numberWithoutRemainder) == 1)
            {
                if (numberWithoutRemainder == 1)
                    return new TranslationDictionary().millionNamber[numberWithoutRemainder] + new TranslationDictionary().trillionName[numberWithoutRemainder];
                if (numberWithoutRemainder == 11)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().trillionName[3];
                return ConvertNumber(numberWithoutRemainder - GetLastNumber(numberWithoutRemainder)) + " " + new TranslationDictionary().millionNamber[GetLastNumber(numberWithoutRemainder)] + new TranslationDictionary().trillionName[GetLastNumber(numberWithoutRemainder)];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 2 && GetLastNumber(numberWithoutRemainder) <= 4)
            {
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().trillionName[2];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 5 || GetLastNumber(numberWithoutRemainder) == 0)
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().trillionName[3];
            return " _ ";
        }
        private string GetQuadrillionName(ulong numberWithoutRemainder)
        {
            if (GetLastNumber(numberWithoutRemainder) == 1)
            {
                if (numberWithoutRemainder == 1)
                    return new TranslationDictionary().millionNamber[numberWithoutRemainder] + new TranslationDictionary().quadrillionName[numberWithoutRemainder];
                if (numberWithoutRemainder == 11)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().quadrillionName[3];
                return ConvertNumber(numberWithoutRemainder - GetLastNumber(numberWithoutRemainder)) + " " + new TranslationDictionary().millionNamber[GetLastNumber(numberWithoutRemainder)] + new TranslationDictionary().quadrillionName[GetLastNumber(numberWithoutRemainder)];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 2 && GetLastNumber(numberWithoutRemainder) <= 4)
            {
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().quadrillionName[2];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 5 || GetLastNumber(numberWithoutRemainder) == 0)
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().quadrillionName[3];
            return " _ ";
        }
        private string GetQuintillionName(ulong numberWithoutRemainder)
        {
            if (GetLastNumber(numberWithoutRemainder) == 1)
            {
                if (numberWithoutRemainder == 1)
                    return new TranslationDictionary().millionNamber[numberWithoutRemainder] + new TranslationDictionary().quintillionName[numberWithoutRemainder];
                if (numberWithoutRemainder == 11)
                    return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().quintillionName[3];
                return ConvertNumber(numberWithoutRemainder - GetLastNumber(numberWithoutRemainder)) + " " + new TranslationDictionary().millionNamber[GetLastNumber(numberWithoutRemainder)] + new TranslationDictionary().quintillionName[GetLastNumber(numberWithoutRemainder)];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 2 && GetLastNumber(numberWithoutRemainder) <= 4)
            {
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().quintillionName[2];
            }
            if (GetLastNumber(numberWithoutRemainder) >= 5 || GetLastNumber(numberWithoutRemainder) == 0)
                return ConvertNumber(numberWithoutRemainder) + new TranslationDictionary().quintillionName[3];
            return " _ ";
        }
        private ulong GetRank(ulong number)
        {
            return new TranslationDictionary().numberRank[GetLengthNumber(number)];
        }
        private int GetLengthNumber(ulong number)
        {
            return Convert.ToString(number).Length;
        }
        private ulong GetLastNumber(ulong numberWithoutRemainder)
        {
            return Convert.ToUInt64(Convert.ToString(numberWithoutRemainder)[Convert.ToString(numberWithoutRemainder).Length - 1] + " ");
        }
    }
}
