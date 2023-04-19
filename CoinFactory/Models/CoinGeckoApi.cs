namespace CoinFactory.Models
{
	public class CoinGeckoApi
	{
		private readonly HttpClient _httpClient;

		public CoinGeckoApi(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<string> GetAsync(string url)
		{
			var response = await _httpClient.GetAsync(url);
			return await response.Content.ReadAsStringAsync();
		}
	}
}
