using System;

namespace DecodingNumberApp
{
    public class Calculation
    {
        public string ConvertAllNumbers(ulong number)
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
            int penultimate = numbersDigits.Length > 1 ? Convert.ToInt32(char.GetNumericValue(numbersDigits[numbersDigits.Length - 2])) : 0;
            if (lastNumber == 1 && penultimate != 1)
            {
                return new DictionaryOfRussianNumbers().valueRank[codeRank];
            }
            else
            {
                if (lastNumber >= 2 && lastNumber <= 4 && penultimate != 1)
                {
                    return new DictionaryOfRussianNumbers().valueRank[codeRank + 1];
                }
                return new DictionaryOfRussianNumbers().valueRank[codeRank + 2];
            }
        }
        private string[] ConvertNumberToFormat(ulong number)
        {
            string numberInFormat = number.ToString(new FormatDictionary().format);
            return numberInFormat.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        private string ConvertSingleNumbers(int singleNumber, int indexNameRank)
        {
            if (singleNumber >= 1 && singleNumber <= 19)
            {
                return ConvertFrom1To19(singleNumber, indexNameRank);
            }
            return ConvertFrom20To999(singleNumber, indexNameRank);
        }
        private string ConvertFrom1To19(int singleNumber, int indexNameRank)
        {
            if (indexNameRank == 2 && (singleNumber == 1 || singleNumber == 2))
            {
                return new DictionaryOfRussianNumbers().thousandNamber[singleNumber];
            }
            return new DictionaryOfRussianNumbers().numberDictionary[singleNumber];
        }
        private string ConvertFrom20To999(int singleNumber, int indexNameRank)
        {
            int remainderOfDivision = singleNumber % GetRank(singleNumber);
            int numberWithoutRemainder = singleNumber - remainderOfDivision;
            if (remainderOfDivision != 0)
            {
                return new DictionaryOfRussianNumbers().numberDictionary[numberWithoutRemainder]
                    + " " + ConvertSingleNumbers(remainderOfDivision, indexNameRank);
            }
            return new DictionaryOfRussianNumbers().numberDictionary[numberWithoutRemainder];
        }
        private int GetRank(int singleNumber)
        {
            return new FormatDictionary().numberRank[Convert.ToString(singleNumber).Length];
        }
    }
}
