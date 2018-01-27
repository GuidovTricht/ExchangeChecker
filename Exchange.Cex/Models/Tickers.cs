using System.Collections.Generic;

namespace Exchange.Cex.Models
{
    public class Tickers
    {
        public string Ok { get; set; }
        public string E { get; set; }
        public List<Ticker> Data { get; set; }
    }
}
