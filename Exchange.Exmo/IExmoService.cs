using Exchange.Exmo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exchange.Exmo
{
    public interface IExmoService
    {
        Task<Dictionary<string, Ticker>> GetTickers();
    }
}
