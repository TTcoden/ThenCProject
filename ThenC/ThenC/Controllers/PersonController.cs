using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using ThenC.Models;
using ThenC.Repository.Person;

namespace ThenC.Controllers
{
	public class PersonController : Controller
	{
		private readonly ILogger<PersonController> _logger;
		private readonly IPersonRepository _personRepository;


		public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository)
		{
			_logger = logger;
			_personRepository = personRepository;
		}

		public IActionResult Index()
		{
			List<PersonModel> Person = _personRepository.GetList();
			return View(Person);
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