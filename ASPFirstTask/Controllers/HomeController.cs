using ASPFirstTask.Entities;
using ASPFirstTask.Models;
using ASPFirstTask.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPFirstTask.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly MenuService _menuService; // Creating Service
		private readonly List<Drink> _drinks;
		private readonly List<HotMeal> _hotMeals;
		private readonly List<FastFood> _fastFoods;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			_menuService = new MenuService();
			_drinks = _menuService.GetDrinks();
			_hotMeals = _menuService.GetHotMeals();
			_fastFoods = _menuService.GetFastFoods();
		}

		public IActionResult Index()
		{
			var vm = new AllItemsViewModel
			{
				Drinks = this._drinks,
				HotMeals = this._hotMeals,
				FastFoods = this._fastFoods
			};

			return View(vm);
		}

		public IActionResult Drinks()
		{
			var vm = new DrinkListViewModel
			{
				Drinks = this._drinks
			};

			return View(vm);
		}

		public IActionResult HotMeals()
		{
			var vm = new HotMealListViewModel
			{
				HotMeals = this._hotMeals
			};

			return View(vm);
		}

		public IActionResult FastFoods()
		{
			var vm = new FastFoodListViewModel
			{
				FastFoods = this._fastFoods
			};

			return View(vm);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
