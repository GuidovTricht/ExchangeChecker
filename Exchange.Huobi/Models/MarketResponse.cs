namespace Exchange.Huobi.Models
{
    public class MarketResponse
    {
        public string Status { get; set; }
        public string Ch { get; set; }
        public long Ts { get; set; }
        public Tick Tick { get; set; }
    }
}
