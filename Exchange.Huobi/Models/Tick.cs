using System.Collections.Generic;

namespace Exchange.Huobi.Models
{
    public class Tick
    {
        public double Close { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Amount { get; set; }
        public int Count { get; set; }
        public double Vol { get; set; }
        public List<double> Ask { get; set; }
        public List<double> Bid { get; set; }
    }
}
