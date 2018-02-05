using Exchange.Bibox.Models;
using RestSharp;

namespace Exchange.Bibox
{
    public class BiboxService : IBiboxService
    {
        private RestClient _restClient;

        public BiboxService()
        {
            _restClient = new RestClient("https://api.bibox.com/v1/"); //https://api.bibox.com/v1/mdata?cmd=market&pair=BIX_BTC
        }

        public MarketsResponse GetAllMarkets()
        {
            var request = new RestRequest(Constants.RequestUriMarkets, Method.GET);

            var response = _restClient.Execute<MarketsResponse>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }

        public MarketResponse GetMarket(string id)
        {
            var request = new RestRequest(Constants.RequestUriMarket, Method.GET);
            request.AddUrlSegment("id", id);

            var response = _restClient.Execute<MarketResponse>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
