namespace Exchange.Gdax.Models
{
    public class Ticker
    {
        public int TradeId { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
        public string Volume { get; set; }
        public string Time { get; set; }
    }
}
