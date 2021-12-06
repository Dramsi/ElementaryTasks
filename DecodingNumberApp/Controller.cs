using System;

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
                object objectNumber = view.SetLongNumber();
                if (objectNumber != null)
                {
                    view.GetStringNumber(ConvertAllNumbers((ulong)objectNumber));
                }
                check = view.RetryMessage();
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
        private string ConvertAllNumbers(ulong number)
        {
            string[] numbersDigits = ConvertNumberToFormat(number);
            string resultOfConvert = null;
            for (int indexRank = 0, indexNameRank = numbersDigits.Length; indexRank < numbersDigits.Length; indexRank++, indexNameRank--)
            {
                if ((Convert.ToInt32(numbersDigits[indexRank])) != 0)
                {
                    resultOfConvert += ConvertSingleNumbers(Convert.ToInt32(numbersDigits[indexRank]), indexNameRank)
                        + GetNameRank(indexNameRank, numbersDigits[indexRank]);
                }
            }
            if (resultOfConvert == null)
            {
                resultOfConvert = new DictionaryOfRussianNumbers().numberDictionary[0];
            }
            return resultOfConvert;
        }
        private string GetNameRank(int indexNameRank, string numbersDigits) 
        {
            int codeRank = indexNameRank * indexNameRank;
            int lastNumber = Convert.ToInt32(char.GetNumericValue(numbersDigits[numbersDigits.Length - 1]));
            if (lastNumber == 1)
            {
                return new DictionaryOfRussianNumbers().valueRank[codeRank];
            }
            else
            {
                if (lastNumber >= 2 && lastNumber <= 4)
                {
                    return new DictionaryOfRussianNumbers().valueRank[codeRank + 1];
                }
                else
                {
                    return new DictionaryOfRussianNumbers().valueRank[codeRank + 2];
                }
            }
        }
        private string[] ConvertNumberToFormat(ulong number)
        {
            string numberInFormat = number.ToString(new FormatDictionary().format);
            numberInFormat = RemoveZeroValues(numberInFormat);
            return numberInFormat.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        private string RemoveZeroValues(string numberInFormat)
        {
            char[] naturalUnits = new FormatDictionary().naturalUnits;
            int indexOfChar = numberInFormat.Length - 1;
            for (int i = 0; i < naturalUnits.Length; i++)
            {
                if (numberInFormat.IndexOf(naturalUnits[i]) != -1 && numberInFormat.IndexOf(naturalUnits[i]) < indexOfChar)
                {
                    indexOfChar = numberInFormat.IndexOf(naturalUnits[i]);
                }
            }
            numberInFormat = numberInFormat.Remove(0, indexOfChar);
            return numberInFormat;
        }
        private string ConvertSingleNumbers(int singleNumber, int indexNameRank)
        {
            if (singleNumber >= 0 && singleNumber <= 19)
            {
                return ConvertFrom1To19(singleNumber, indexNameRank);
            }
            else
            {
                return ConvertFrom20(singleNumber, indexNameRank);
            }
        }
        private string ConvertFrom1To19(int singleNumber, int indexNameRank)
        {
            if (indexNameRank == 2 && (singleNumber == 1 || singleNumber == 2))
            {
                return new DictionaryOfRussianNumbers().thousandNamber[singleNumber];
            }
            else
            {
                return new DictionaryOfRussianNumbers().numberDictionary[singleNumber];
            }
        }
        private string ConvertFrom20(int singleNumber, int indexNameRank)
        {
            int remainderOfDivision = singleNumber % GetRank(singleNumber);
            int numberWithoutRemainder = singleNumber - remainderOfDivision;
            if (remainderOfDivision != 0)
            {
                return new DictionaryOfRussianNumbers().numberDictionary[numberWithoutRemainder]
                    + " " + ConvertSingleNumbers(remainderOfDivision, indexNameRank);
            }
            else
            {
                return new DictionaryOfRussianNumbers().numberDictionary[numberWithoutRemainder];
            }
        }
        private int GetRank(int singleNumber)
        {
            return new FormatDictionary().numberRank[Convert.ToString(singleNumber).Length];
        }
    }
}
