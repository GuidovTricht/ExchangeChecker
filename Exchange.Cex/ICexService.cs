using Exchange.Cex.Models;
using System.Threading.Tasks;

namespace Exchange.Cex
{
    public interface ICexService
    {
        Task<Ticker> GetTicker(string firstCurrency, string secondCurrency);
        Task<Tickers> GetTickers(string firstCurrency = "BTC", string secondCurrency = "EUR");
    }
}
