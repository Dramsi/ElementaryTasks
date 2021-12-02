using System.Collections.Generic;

namespace DecodingNumberApp
{
    class FormatDictionary
    {
        public string format = "000 000 000 000 000 000 000";
        public char[] naturalUnits = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public Dictionary<int, int> numberRank = new Dictionary<int, int>()
        {
            { 2, 10 },
            { 3, 100 }
        };
    }
}
