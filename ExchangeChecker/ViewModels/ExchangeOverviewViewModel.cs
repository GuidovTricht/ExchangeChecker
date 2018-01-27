using System.Collections.Generic;

namespace ExchangeChecker.ViewModels
{
    public class ExchangeOverviewViewModel
    {
        public List<ExchangeDetails> Exchanges { get; set; }
    }

    public class ExchangeDetails
    {
        public string Name { get; set; }
        public string BitcoinPrice { get; set; }
        public string EthereumPrice { get; set; }
        public string LitecoinPrice { get; set; }
    }
}
