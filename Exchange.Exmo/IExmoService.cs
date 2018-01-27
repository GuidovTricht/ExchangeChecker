using Exchange.Exmo.Models;
using System.Collections.Generic;

namespace Exchange.Exmo
{
    public interface IExmoService
    {
        Dictionary<string, Ticker> GetTickers();
    }
}
