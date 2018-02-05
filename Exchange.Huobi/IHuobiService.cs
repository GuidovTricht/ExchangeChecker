using Exchange.Huobi.Models;

namespace Exchange.Huobi
{
    public interface IHuobiService
    {
        MarketResponse GetMarket(string id);
    }
}
