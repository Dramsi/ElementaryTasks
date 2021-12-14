using System.Collections.Generic;

namespace DecodingNumberApp
{
    class FormatDictionary
    {
        public string format = "000 000 000 000 000 000 000";
        public Dictionary<int, int> numberRank = new Dictionary<int, int>()
        {
            { 2, 10 },
            { 3, 100 }
        };
    }
}
