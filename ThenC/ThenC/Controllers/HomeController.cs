﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using ThenC.Models;
using ThenC.Repository.Person;

namespace ThenC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ITablesRepository _personRepository;


		public HomeController(ILogger<HomeController> logger, ITablesRepository personRepository)
		{
			_logger = logger;
			_personRepository = personRepository;
		}

		public IActionResult Index()
		{
			
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}