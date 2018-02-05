using Exchange.Bibox.Models;
using System.Threading.Tasks;

namespace Exchange.Bibox
{
    public interface IBiboxService
    {
        Task<MarketsResponse> GetAllMarkets();
        Task<MarketResponse> GetMarket(string id);
    }
}
