using System.Collections.Generic;

namespace Exchange.Coinbase.Models
{
    public class Ticker
    {
        public string Currency { get; set; }
        public Dictionary<string, string> Rates { get; set; }
    }
}
