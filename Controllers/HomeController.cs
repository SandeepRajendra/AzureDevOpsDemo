using AzureDevOpsDemo.Models;
using AzureDevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevOpsDemo.Controllers
{
	public class HomeController : Controller
	{
		//private readonly ILogger<HomeController> _logger;
		IPostRepository postRepository;
		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}
		public HomeController(IPostRepository _postRepository)
		{
			postRepository = _postRepository;
		}

		public IActionResult Index()
		{
			var model = postRepository.GetPosts();
			return View(model);
		}
		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";
			return View();
		}
		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";
			return View();
		}
		public IActionResult Privacy()
		{
			//var model = postRepository.GetPosts();
			//return View(model);
			return View();
		}
		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		
		
	}
}
