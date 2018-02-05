using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExchangeChecker.Models;
using Exchange.Gdax;
using Exchange.Kraken;
using ExchangeChecker.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Exchange.Exmo;
using Exchange.Cex;
using Exchange.Coinbase;
using Exchange.Bitstamp;
using Exchange.Bibox;
using Exchange.Huobi;

namespace ExchangeChecker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGdaxService gdaxService;
        private readonly IKrakenService krakenService;
        private readonly IExmoService exmoService;
        private readonly ICexService cexService;
        private readonly ICoinbaseService coinbaseService;
        private readonly IBitstampService bitstampService;
        private readonly IBiboxService biboxService;
        private readonly IHuobiService huobiService;

        public HomeController()
        {
            gdaxService = new GdaxService();
            krakenService = new KrakenService();
            exmoService = new ExmoService();
            cexService = new CexService();
            coinbaseService = new CoinbaseService();
            bitstampService = new BitstampService();
            biboxService = new BiboxService();
            huobiService = new HuobiService();
        }

        public IActionResult Index(string currency = "EUR")
        {
            var exmoTickers = exmoService.GetTickers().GetAwaiter().GetResult();

            var viewModel = new ExchangeOverviewViewModel()
            {
                Exchanges = new List<ExchangeDetails>()
                {
                    new ExchangeDetails()
                    {
                        Name = "GDAX",
                        BitcoinPrice = gdaxService.GetTicker("BTC-" + currency).GetAwaiter().GetResult()?.Price,
                        EthereumPrice = gdaxService.GetTicker("ETH-" + currency).GetAwaiter().GetResult()?.Price,
                        LitecoinPrice = gdaxService.GetTicker("LTC-" + currency).GetAwaiter().GetResult()?.Price
                    },
                    new ExchangeDetails()
                    {
                        Name = "Kraken",
                        BitcoinPrice = krakenService.GetTicker("BTC" + currency).GetAwaiter().GetResult()?.C?.FirstOrDefault(),
                        EthereumPrice = krakenService.GetTicker("ETH" + currency).GetAwaiter().GetResult()?.C?.FirstOrDefault(),
                        LitecoinPrice = krakenService.GetTicker("LTC" + currency).GetAwaiter().GetResult()?.C?.FirstOrDefault()
                    },
                    new ExchangeDetails()
                    {
                        Name = "Exmo",
                        BitcoinPrice = exmoTickers?.FirstOrDefault(r => r.Key == "BTC_" + currency).Value?.LastTrade,
                        EthereumPrice = exmoTickers?.FirstOrDefault(r => r.Key == "ETH_" + currency).Value?.LastTrade,
                        LitecoinPrice = exmoTickers?.FirstOrDefault(r => r.Key == "LTC_" + currency).Value?.LastTrade
                    },
                    new ExchangeDetails()
                    {
                        Name = "Cex",
                        BitcoinPrice = cexService.GetTicker("BTC", currency).GetAwaiter().GetResult()?.Last,
                        EthereumPrice = cexService.GetTicker("ETH", currency).GetAwaiter().GetResult()?.Last,
                        LitecoinPrice = cexService.GetTicker("LTC", currency).GetAwaiter().GetResult()?.Last
                    },
                    new ExchangeDetails()
                    {
                        Name = "Coinbase",
                        BitcoinPrice = coinbaseService.GetTickers("BTC").GetAwaiter().GetResult()?.Data?.Rates?.FirstOrDefault(r => r.Key == currency).Value,
                        EthereumPrice = coinbaseService.GetTickers("ETH").GetAwaiter().GetResult()?.Data?.Rates?.FirstOrDefault(r => r.Key == currency).Value,
                        LitecoinPrice = coinbaseService.GetTickers("LTC").GetAwaiter().GetResult()?.Data?.Rates?.FirstOrDefault(r => r.Key == currency).Value
                    },
                    new ExchangeDetails()
                    {
                        Name = "Bitstamp",
                        BitcoinPrice = bitstampService.GetTicker("BTC" + currency).GetAwaiter().GetResult()?.Last,
                        EthereumPrice = bitstampService.GetTicker("ETH" + currency).GetAwaiter().GetResult()?.Last,
                        LitecoinPrice = bitstampService.GetTicker("LTC" + currency).GetAwaiter().GetResult()?.Last
                    },
                    new ExchangeDetails()
                    {
                        Name = "Bibox",
                        BitcoinPrice = biboxService.GetMarket("BTC_" + currency).GetAwaiter().GetResult()?.Result?.Last,
                        EthereumPrice = biboxService.GetMarket("ETH_" + currency).GetAwaiter().GetResult()?.Result?.Last,
                        LitecoinPrice = biboxService.GetMarket("LTC_" + currency).GetAwaiter().GetResult()?.Result?.Last
                    },
                    new ExchangeDetails()
                    {
                        Name = "Huobi",
                        BitcoinPrice = huobiService.GetMarket("BTC" + currency).GetAwaiter().GetResult()?.Tick?.Close.ToString(),
                        EthereumPrice = huobiService.GetMarket("ETH" + currency).GetAwaiter().GetResult()?.Tick?.Close.ToString(),
                        LitecoinPrice = huobiService.GetMarket("LTC" + currency).GetAwaiter().GetResult()?.Tick?.Close.ToString()
                    }
                }
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
