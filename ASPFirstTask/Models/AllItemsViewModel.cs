using ASPFirstTask.Entities;
using System.Collections.Generic;

namespace ASPFirstTask.Models
{
	public class AllItemsViewModel
	{
		public List<Drink> Drinks { get; set; }
		public List<FastFood> FastFoods {get;set;}
		public List<HotMeal> HotMeals { get; set; }
	}
}
