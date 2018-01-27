using Exchange.Gdax.Models;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace Exchange.Gdax
{
    public class GdaxService : IGdaxService
    {
        private RestClient _restClient;

        public GdaxService()
        {
            _restClient = new RestClient("https://api.gdax.com/"); //https://api.gdax.com/products/ETH-EUR/ticker
        }

        public List<Product> GetProducts(string quoteCurrency = "")
        {
            var request = new RestRequest(Constants.RequestUriProducts, Method.GET);

            var response = _restClient.Execute<List<Product>>(request);
            if (response != null && response.IsSuccessful)
            {
                if (!string.IsNullOrEmpty(quoteCurrency))
                    return response.Data.Where(p => p.QuoteCurrency == quoteCurrency).ToList();
                return response.Data;
            }

            return null;
        }

        public Product GetProductById(string id)
        {
            var request = new RestRequest(Constants.RequestUriProduct, Method.GET);
            request.AddUrlSegment("id", id);

            var response = _restClient.Execute<Product>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }

        public Ticker GetTicker(string id)
        {
            var request = new RestRequest(Constants.RequestUriTicker, Method.GET);
            request.AddUrlSegment("id", id);

            var response = _restClient.Execute<Ticker>(request);
            if(response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }
    }
}
