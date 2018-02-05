using System.Collections.Generic;

namespace Exchange.Bibox.Models
{
    public class MarketsResponse
    {
        public List<Market> Result { get; set; }
        public string Cmd { get; set; }
    }
}
