namespace Exchange.Gdax.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string BaseCurreny { get; set; }
        public string QuoteCurrency { get; set; }
        public string BaseMinSize { get; set; }
        public string BaseMaxSize { get; set; }
        public string QuoteIncrement { get; set; }
        public string DisplayName { get; set; }
        public string Status { get; set; }
        public bool MarginEnabled { get; set; }
        public string StatusMessage { get; set; }
        public string MinMarketFunds { get; set; }
        public string MaxMarketFunds { get; set; }
        public bool PostOnly { get; set; }
        public bool LimitOnly { get; set; }
        public bool CancelOnly { get; set; }
    }
}
