using Exchange.Coinbase.Models;

namespace Exchange.Coinbase
{
    public interface ICoinbaseService
    {
        TickersResult GetTickers(string currency);
    }
}
