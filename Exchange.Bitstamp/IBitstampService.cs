using Exchange.Bitstamp.Models;
using System.Threading.Tasks;

namespace Exchange.Bitstamp
{
    public interface IBitstampService
    {
        Task<Ticker> GetTicker(string id);
    }
}
