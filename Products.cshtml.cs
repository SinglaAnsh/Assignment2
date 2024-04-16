using ClassCrafts.Models;
using ClassCrafts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// Add the required code:
namespace ClassCrafts.Pages
{
    public class ProductsModel : PageModel
    {
        //public void OnGet()
        //{
        //}

        // Add the JSON file services:
        // Adding the public service property of type "JsonFileProductService":
        public JsonFileProductService ProductService;
        /*
        Solution#1: 
        ***********
        adding this syntax after the closing brace:
        = Enumerable.Empty<Product>();

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings?f1url=%3FappId%3Droslyn%26k%3Dk(CS8618)#nonnullable-reference-not-initialized

		Solution#2: 
        ***********
        adding this special syntax of C# called "Null safety" after the closing brace:
        = default!;

        Link: https://learn.microsoft.com/en-us/training/modules/csharp-null-safety/

        <generic>
        */
        public IEnumerable<Product>? Products { get; set; }

        // add the class constructor:


        public ProductsModel(JsonFileProductService productService) {
			ProductService = productService;
		}


        public void OnGet()
        {
            Products = ProductService.GetProducts();
		}

    } // class
} // namespace
