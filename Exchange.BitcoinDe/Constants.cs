namespace Exchange.BitcoinDe
{
    public static class Constants
    {
        public const string RequestUriTradehistory = "{key}/trades.json"; //Optional ?since=123
        public const string RequestUriOrderbook = "{key}/orderbook.json";
        public const string RequestUriTicker = "{key}/rate.json";
    }
}
