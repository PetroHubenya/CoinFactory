namespace CoinFactory.Models
{
	public class Coin
	{
		/* Below properties correspond to "/search/trending".
		 * Get trending search coins (Top-7) on CoinGecko in the last 24 hours.*/

		public string Id { get; set; }
		public int CoinId { get; set; }
		public string Name { get; set; }
		public string Symbol { get; set; }
		public int MarketCapRank { get; set; }

		// The smallest logo link.
		public string Thumb { get; set; }

		// The small logo link.
		public string Small { get; set; }

		// The large logo link.
		public string Large { get; set; }

		public string Slug { get; set; }
		
		// Price of the coin in Bitcoins.
		public double PriceBtc { get; set; }
		public int Score { get; set; }
		

		// Constructor.

		public Coin(string id,
					int coinId,
					string name,
					string symbol,
					int marketCapRank,
					string thumb,
					string small,
					string large,
					string slug,
					double priceBtc,
					int score)
		{
			Id = id;
			CoinId = coinId;
			Name = name;
			Symbol = symbol;
			MarketCapRank = marketCapRank;
			Thumb = thumb;
			Small = small;
			Large = large;
			Slug = slug;
			PriceBtc = priceBtc;
			Score = score;			
		}


	}
}
