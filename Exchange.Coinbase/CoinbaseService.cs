using Exchange.Coinbase.Models;
using RestSharp;

namespace Exchange.Coinbase
{
    public class CoinbaseService : ICoinbaseService
    {
        private RestClient _restClient;

        public CoinbaseService()
        {
            _restClient = new RestClient("https://api.coinbase.com/v2/"); //https://api.coinbase.com/v2/exchange-rates?currency=BTC
        }

        public TickersResult GetTickers(string currency)
        {
            var request = new RestRequest(Constants.RequestUriTickers, Method.GET);
            request.AddUrlSegment("currency", currency);

            var response = _restClient.Execute<TickersResult>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
