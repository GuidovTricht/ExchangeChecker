namespace Exchange.Cex.Models
{
    public class Ticker
    {
        public string Timestamp { get; set; }
        public string Pair { get; set; } //"BTC:EUR"
        public string Low { get; set; }
        public string High { get; set; }
        public string Last { get; set; }
        public string Volume { get; set; }
        public string Volume30d { get; set; }
        public float Bid { get; set; }
        public float Ask { get; set; }
    }
}

/**
 * 
 * {
  "timestamp": "1513166480",
  "low": "17200",
  "high": "17920",
  "last": "17420",
  "volume": "2042.59581123",
  "volume30d": "81150.14153359",
  "bid": 17400.04,
  "ask": 17418.2
}
 * 
 * **/
