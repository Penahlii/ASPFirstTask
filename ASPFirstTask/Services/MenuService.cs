using ASPFirstTask.Entities;
using System.Collections.Generic;

namespace ASPFirstTask.Services
{
	public class MenuService // Getting Fake data from this Service
	{
		public List<Drink> GetDrinks()
		{
			return new List<Drink>
			{
				new Drink { ID = 1, Name = "Coca Cola", Price = 1.50m, IsAlcoholic = false },
				new Drink { ID = 2, Name = "Pepsi", Price = 1.50m, IsAlcoholic = false },
				new Drink { ID = 3, Name = "Red Wine", Price = 5.00m, IsAlcoholic = true }
			};
		}

		public List<HotMeal> GetHotMeals()
		{
			return new List<HotMeal>
			{
				new HotMeal { ID = 1, Name = "Spaghetti Bolognese", Price = 8.99m, IsVegetarian = false },
				new HotMeal { ID = 2, Name = "Vegetarian Pizza", Price = 9.99m, IsVegetarian = true },
				new HotMeal { ID = 3, Name = "Grilled Chicken", Price = 12.99m, IsVegetarian = false }
			};
		}

		public List<FastFood> GetFastFoods()
		{
			return new List<FastFood>
			{
				new FastFood { ID = 1, Name = "Cheeseburger", Price = 4.99m, Calories = 550 },
				new FastFood { ID = 2, Name = "French Fries", Price = 2.99m, Calories = 300 },
				new FastFood { ID = 3, Name = "Chicken Nuggets", Price = 5.99m, Calories = 450 }
			};
		}
	}
}
