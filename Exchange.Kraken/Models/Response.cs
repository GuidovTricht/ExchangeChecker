using System.Collections.Generic;

namespace Exchange.Kraken.Models
{
    public class Response
    {
        public List<object> Error { get; set; }
        public Dictionary<string, TickerDetails> Result { get; set; }
    }
}
