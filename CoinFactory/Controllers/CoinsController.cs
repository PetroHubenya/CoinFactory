using CoinFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoinFactory.Controllers
{
	public class CoinsController : Controller
	{
		private readonly CoinGeckoApi _coinGeckoApi;

		public CoinsController(HttpClient httpClient)
		{
			_coinGeckoApi = new CoinGeckoApi(httpClient);
		}


		// Get list of all supported coins id, name and symbol (no pagination required)
		public async Task<IActionResult> Index()
		{
			// Receive data in json format.
			var data = await _coinGeckoApi.GetAsync("https://api.coingecko.com/api/v3/coins/list");
			// Convert received data from json format to list of Coin class instances.
			var coins = JsonConvert.DeserializeObject<List<Coin>>(data);
            return View(coins);
		}

        // Get current data (name, price, market, ... including exchange tickers) for a coin.
        public async Task<IActionResult> Details(string id)
        {
            // Receive data in json format.
            var data = await _coinGeckoApi.GetAsync($"https://api.coingecko.com/api/v3/coins/{id}");
            // Convert received data from json format to Coin class instance.
            Coin coin = JsonConvert.DeserializeObject<Coin>(data.ToString());

            return View(coin);
        }
    }
}
