using Exchange.Bitstamp.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Exchange.Bitstamp
{
    public class BitstampService : IBitstampService
    {
        private RestClient _restClient;

        public BitstampService()
        {
            _restClient = new RestClient("https://www.bitstamp.net/api/v2/"); //https://www.bitstamp.net/api/v2/ticker/BTCEUR/
        }

        public async Task<Ticker> GetTicker(string id)
        {
            var request = new RestRequest(Constants.RequestUriTicker, Method.GET);
            request.AddUrlSegment("id", id);

            var response = await _restClient.ExecuteTaskAsync<Ticker>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
