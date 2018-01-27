using Exchange.Kraken.Models;

namespace Exchange.Kraken
{
    public interface IKrakenService
    {
        TickerDetails GetTicker(string pair);
    }
}
