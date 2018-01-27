using Exchange.Cex.Models;

namespace Exchange.Cex
{
    public interface ICexService
    {
        Ticker GetTicker(string firstCurrency, string secondCurrency);
        Tickers GetTickers(string firstCurrency = "BTC", string secondCurrency = "EUR");
    }
}
