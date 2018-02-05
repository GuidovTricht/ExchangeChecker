using Exchange.Gdax.Models;
using System.Threading.Tasks;

namespace Exchange.Gdax
{
    public interface IGdaxService
    {
        Task<Ticker> GetTicker(string id);
    }
}
