namespace LuckyTicketsApp
{
    class LuckyTickets
    {
        public string format = "000000";
        private int minTiketValue;       
        private int maxTiketValue;
        public int MinTiketValue
        {
            get
            {
                return minTiketValue;
            }
        }
        public int MaxTiketValue
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
