using Exchange.Kraken.Models;
using RestSharp;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange.Kraken
{
    public class KrakenService : IKrakenService
    {
        private RestClient _restClient;

        public KrakenService()
        {
            _restClient = new RestClient("https://api.kraken.com/0/");
        }

        public async Task<TickerDetails> GetTicker(string pair)
        {
            var request = new RestRequest(Constants.RequestUriTicker, Method.GET);
            request.AddUrlSegment("pair", pair);

            var response = await _restClient.ExecuteTaskAsync<Response>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data?.Result?.FirstOrDefault().Value;
            }

            return null;
        }
    }
}
