using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using ThenC.Models;
using ThenC.Repository.Person;

namespace ThenC.Controllers
{
	public class TablesController : Controller
	{
		private readonly ILogger<TablesController> _logger;
		private readonly ITablesRepository _tablesRepository;


		public TablesController(ILogger<TablesController> logger, ITablesRepository tablesRepository)
		{
			_logger = logger;
            _tablesRepository = tablesRepository;
		}

		public IActionResult Index()
		{
			List<TablesModel> Tables = _tablesRepository.GetList();
			return View(Tables);
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

        public IActionResult Create()
        {
			return View();
        }
    }
}