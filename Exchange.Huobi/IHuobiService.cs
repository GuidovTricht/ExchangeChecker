using Exchange.Huobi.Models;
using System.Threading.Tasks;

namespace Exchange.Huobi
{
    public interface IHuobiService
    {
        Task<MarketResponse> GetMarket(string id);
    }
}
