using Exchange.Bibox.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Exchange.Bibox
{
    public class BiboxService : IBiboxService
    {
        private RestClient _restClient;

        public BiboxService()
        {
            _restClient = new RestClient("https://api.bibox.com/v1/"); //https://api.bibox.com/v1/mdata?cmd=market&pair=BIX_BTC
        }

        public async Task<MarketsResponse> GetAllMarkets()
        {
            var request = new RestRequest(Constants.RequestUriMarkets, Method.GET);

            var response = await _restClient.ExecuteTaskAsync<MarketsResponse>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }

        public async Task<MarketResponse> GetMarket(string id)
        {
            var request = new RestRequest(Constants.RequestUriMarket, Method.GET);
            request.AddUrlSegment("id", id);

            var response = await _restClient.ExecuteTaskAsync<MarketResponse>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
