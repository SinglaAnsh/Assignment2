using System.Text.Json.Serialization;

namespace ClassCrafts.Models
{
	public class Product
	{
		public string? Id {  get; set; }
		public string? Maker { get; set; }

		[JsonPropertyName("img")]
		public string? Image { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		


		// we will check :-)
	}
}
