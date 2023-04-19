using CoinFactory.Models;
using Microsoft.AspNetCore.Mvc;

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
			var data = await _coinGeckoApi.GetAsync("https://api.coingecko.com/api/v3/coins/list");
			return View(data);
		}
	}
}
