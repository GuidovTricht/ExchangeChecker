using System.Collections.Generic;

namespace Exchange.Kraken.Models
{
    public class TickerDetails
    {
        public List<string> A { get; set; } //ask array(<price>, <whole lot volume>, <lot volume>)
        public List<string> B { get; set; } //bid array(<price>, <whole lot volume>, <lot volume>)
        public List<string> C { get; set; } //last trade closed array(<price>, <lot volume>)
        public List<string> V { get; set; } //volume array(<today>, <last 24 hours>)
        public List<string> P { get; set; } //volume weighted average price array(<today>, <last 24 hours>)
        public List<int> T { get; set; } //number of trades array(<today>, <last 24 hours>)
        public List<string> L { get; set; } //low array(<today>, <last 24 hours>)
        public List<string> H { get; set; } //high array(<today>, <last 24 hours>)
        public string O { get; set; } //today's opening price
    }
}
