using Exchange.Coinbase.Models;
using System.Threading.Tasks;

namespace Exchange.Coinbase
{
    public interface ICoinbaseService
    {
        Task<TickersResult> GetTickers(string currency);
    }
}
