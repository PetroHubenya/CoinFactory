namespace CoinFactory.Models
{
	public class Environment
	{
		// Write the property taht will contain API URL.
		public string ApiUrl { get; set; }

		// Write the constructor to create an instance with the property, containing API URL.
		public Environment(string apiUrl)
		{
			ApiUrl = apiUrl;
		}

		// Write the method, that reads the API_URL.tsv file and gives it's value to property of Environment instance.
		public static Environment FromTsv(string tsvLine)
		{
			/* This code opens the file in read mode and reads a single line from it using the ReadLine() method.
			 * The line is then stored in the line variable as a string.*/

			string line;
			
			using (StreamReader file = new StreamReader("API_URL.tsv"))
			{
				line = file.ReadLine();
			}

			// Create and return an inctance of the Environment class with the property containing API URL.

			Environment environment = new Environment(line);

			return environment;
		}


	}
}
