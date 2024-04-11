using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using ThenC.Models;
using ThenC.Repository.Person;

namespace ThenC.Controllers
{
	public class FormsController : Controller
	{
		private readonly ILogger<TablesController> _logger;
		private readonly ITablesRepository _formsRepository;


		public FormsController(ILogger<TablesController> logger, ITablesRepository formsRepository)
		{
			_logger = logger;
            _formsRepository = formsRepository;
		}

		public IActionResult Index()
		{
			List<TablesModel> Forms = _formsRepository.GetList();
			return View(Forms);
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