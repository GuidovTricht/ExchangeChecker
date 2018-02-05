using Exchange.Huobi.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Exchange.Huobi
{
    public class HuobiService : IHuobiService
    {
        private RestClient _restClient;

        public HuobiService()
        {
            _restClient = new RestClient("https://api.huobi.pro/"); //https://api.huobi.pro/market/detail/merged?symbol=ethbtc
        }

        public async Task<MarketResponse> GetMarket(string id)
        {
            id = id.ToLower();

            var request = new RestRequest(Constants.RequestUriMarket, Method.GET);
            request.AddUrlSegment("id", id);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

            var response = await _restClient.ExecuteTaskAsync<MarketResponse>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
