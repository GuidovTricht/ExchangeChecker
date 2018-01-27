using Exchange.Bitstamp.Models;

namespace Exchange.Bitstamp
{
    public interface IBitstampService
    {
        Ticker GetTicker(string id);
    }
}
