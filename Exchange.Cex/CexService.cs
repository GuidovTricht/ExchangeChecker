using Exchange.Cex.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Exchange.Cex
{
    public class CexService : ICexService
    {
        private RestClient _restClient;

        public CexService()
        {
            _restClient = new RestClient("https://cex.io/api/"); //https://cex.io/api/tickers/BTC/EUR
        }

        public async Task<Ticker> GetTicker(string firstCurrency, string secondCurrency)
        {
            var request = new RestRequest(Constants.RequestUriTicker, Method.GET);
            request.AddUrlSegment("firstCurrency", firstCurrency);
            request.AddUrlSegment("secondCurrency", secondCurrency);

            var response = await _restClient.ExecuteTaskAsync<Ticker>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }

        public async Task<Tickers> GetTickers(string firstCurrency = "BTC", string secondCurrency = "EUR")
        {
            var request = new RestRequest(Constants.RequestUriTickers, Method.GET);
            request.AddUrlSegment("firstCurrency", firstCurrency);
            request.AddUrlSegment("secondCurrency", secondCurrency);

            var response = await _restClient.ExecuteTaskAsync<Tickers>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
