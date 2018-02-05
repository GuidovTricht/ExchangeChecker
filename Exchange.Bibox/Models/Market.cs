namespace Exchange.Bibox.Models
{
    public class Market
    {
        public int Id { get; set; }
        public string CoinSymbol { get; set; }
        public string CurrencySymbol { get; set; }
        public string Last { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Change { get; set; }
        public string Percent { get; set; }
        public string Vol24H { get; set; }
        public string Amount { get; set; }
        public string LastCny { get; set; }
        public string HighCny { get; set; }
        public string LowCny { get; set; }
        public string LastUsd { get; set; }
        public string HighUsd { get; set; }
        public string LowUsd { get; set; }
    }
}
