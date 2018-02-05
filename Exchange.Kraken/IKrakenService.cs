using Exchange.Kraken.Models;
using System.Threading.Tasks;

namespace Exchange.Kraken
{
    public interface IKrakenService
    {
        Task<TickerDetails> GetTicker(string pair);
    }
}
