using System;
using System.Collections.Generic;
using Exchange.Exmo.Models;
using RestSharp;

namespace Exchange.Exmo
{
    public class ExmoService : IExmoService
    {
        private RestClient _restClient;

        public ExmoService()
        {
            _restClient = new RestClient("https://api.exmo.com/v1/"); //https://api.exmo.com/v1/order_book/?pair=BTC_USD
        }

        public Dictionary<string, Ticker> GetTickers()
        {
            var request = new RestRequest(Constants.RequestUriTicker, Method.GET);

            var response = _restClient.Execute<Dictionary<string, Ticker>>(request);
            if (response != null && response.IsSuccessful)
            {
                return response.Data;
            }

            return null;
        }

        private int Dictionary<T1, T2>(RestRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
