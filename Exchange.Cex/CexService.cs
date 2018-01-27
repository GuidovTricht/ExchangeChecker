using Exchange.Cex.Models;
using RestSharp;

namespace Exchange.Cex
{
    public class CexService : ICexService
    {
        private RestClient _restClient;

        public CexService()
        {
            _restClient = new RestClient("https://cex.io/api/"); //https://cex.io/api/tickers/BTC/EUR
        }

        public Ticker GetTicker(string firstCurrency, string secondCurrency)
        {
            var request = new RestRequest(Constants.RequestUriTicker, Method.GET);
            request.AddUrlSegment("firstCurrency", firstCurrency);
            request.AddUrlSegment("secondCurrency", secondCurrency);

            var response = _restClient.Execute<Ticker>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }

        public Tickers GetTickers(string firstCurrency = "BTC", string secondCurrency = "EUR")
        {
            var request = new RestRequest(Constants.RequestUriTickers, Method.GET);
            request.AddUrlSegment("firstCurrency", firstCurrency);
            request.AddUrlSegment("secondCurrency", secondCurrency);

            var response = _restClient.Execute<Tickers>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
