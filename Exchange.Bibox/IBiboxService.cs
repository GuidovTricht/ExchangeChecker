using Exchange.Bibox.Models;

namespace Exchange.Bibox
{
    public interface IBiboxService
    {
        MarketsResponse GetAllMarkets();
        MarketResponse GetMarket(string id);
    }
}
