namespace CoinFactory.Models
{
	public class Currency
	{
		public string CurrencyCode { get; set; }
		public string CurrencyName { get; set; }
		public double CurrencyPrice { get; set; }
		public string CurrencyVolume { get; set; }
		public string CurrencyWebPage { get; set; }

		public Currency(string currencyCode, 
						string currencyName,
						double currencyPrice,
						string currencyVolume,
						string currencyWebPage)
		{
			CurrencyCode = currencyCode;
			CurrencyName = currencyName;
			CurrencyPrice = currencyPrice;
			CurrencyVolume = currencyVolume;
			CurrencyWebPage = currencyWebPage;
		}

	}
}
