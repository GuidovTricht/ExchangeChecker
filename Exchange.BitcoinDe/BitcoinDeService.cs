using RestSharp;

namespace Exchange.BitcoinDe
{
    public class BitcoinDeService : IBitcoinDeService
    {
        private RestClient _restClient;

        public BitcoinDeService()
        {
            _restClient = new RestClient("https://bitcoinapi.de/v1/"); //https://bitcoinapi.de/v1/YOUR_API_KEY/rate.json
        }

        public object GetRate() //https://bitcoinapi.de/v1/YOUR_API_KEY/rate.json
        {
            return null;
        }
    }
}
