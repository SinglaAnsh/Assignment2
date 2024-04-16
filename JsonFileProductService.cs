using System.Text.Json;
using ClassCrafts.Models;

namespace ClassCrafts.Services
{
	public class JsonFileProductService
	{
		// constructor:
		public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		// add property of type "IWebHostEnvironment"
		public IWebHostEnvironment WebHostEnvironment { get; }

		// one more property for the "JsonFileName":

		/*
		private string JsonFileName
		{
			get
			{
				// get has to return the full location of your JSON file as a string
				// Web Host Env. + website root path
				return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");
			}
		}
		*/

		// Or using the C# short version:
		private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");

		
		/*
		 *  Getting/retrieving the data (products) from the JSON file:
        adding a public method "GetProducts()"

		returns a list of products:
		every item in this list is of type "
		generics<>
		in Java
		ArrayList<String> myArrayList = ....
		Enumerable Interface

		IEnumerable => Is the root "interface" for all the lists/collections that we have in CS
		 */
		public IEnumerable<Product> GetProducts() 
		{
			// (File I/O) => Open the text file 
			// C:\....\CoolCrafts\CoolCrafts\data
			using var jsonFileReader = File.OpenText(JsonFileName);
			// With JSON Serialize (TO JSON) and Deserialize (FROM JSON)
			return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
				new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true
				})!;
			/*
		NOTE: We will receive a warning if we omit the symbol "!":
		CS8603 - Possible null reference return.

		Solution: add the null forgiving operator, ! to the right-hand side "!"
		Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings?f1url=%3FappId%3Droslyn%26k%3Dk(CS8603)#possible-null-assigned-to-a-nonnullable-reference
		 */
		}
	} // class
} // namespace
