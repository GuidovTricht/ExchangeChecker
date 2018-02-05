using Exchange.Coinbase.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Exchange.Coinbase
{
    public class CoinbaseService : ICoinbaseService
    {
        private RestClient _restClient;

        public CoinbaseService()
        {
            _restClient = new RestClient("https://api.coinbase.com/v2/"); //https://api.coinbase.com/v2/exchange-rates?currency=BTC
        }

        public async Task<TickersResult> GetTickers(string currency)
        {
            var request = new RestRequest(Constants.RequestUriTickers, Method.GET);
            request.AddUrlSegment("currency", currency);

            var response = await _restClient.ExecuteTaskAsync<TickersResult>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
