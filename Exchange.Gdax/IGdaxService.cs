using Exchange.Gdax.Models;

namespace Exchange.Gdax
{
    public interface IGdaxService
    {
        Ticker GetTicker(string id);
    }
}
