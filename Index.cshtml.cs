using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassCrafts.Pages
{
	public class IndexModel : PageModel
	{
		/*
	  Logging:
	  ASP.NET Core supports a logging API that works with a variety 
	  of built-in and third-party logging providers. 
	  Link: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-7.0&tabs=windows#logging
	   */
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}
