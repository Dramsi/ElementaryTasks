namespace LuckyTicketsApp
{
    public class LuckyTickets
    {
        public string format = "000000";
        private int minTiketValue;       
        private int maxTiketValue;
        public int MinTiсketValue
        {
            get
            {
                return minTiketValue;
            }
        }
        public int MaxTiсketValue
        {
            get
            {
                return maxTiketValue;
            }
        }
        public LuckyTickets(int minTiketValue, int maxTiketValue)
        {
            this.minTiketValue = minTiketValue;
            this.maxTiketValue = maxTiketValue;
        }
    }
}
