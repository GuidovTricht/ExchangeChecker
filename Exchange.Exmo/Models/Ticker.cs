namespace Exchange.Exmo.Models
{
    public class Ticker
    {
        public string BuyPrice { get; set; }
        public string SellPrice { get; set; }
        public string LastTrade { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Avg { get; set; }
        public string Vol { get; set; }
        public string VolCurr { get; set; }
        public long Updated { get; set; }
    }
}
