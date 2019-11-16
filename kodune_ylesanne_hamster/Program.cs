using System;

namespace kodune_ylesanne_hamster
{
	class Animal
	{
		public string name;
		public int age = 0;
		public double weight = 0.1;
		public int lifespan = 0;
		public double foodIntake;
		public double weightloss;

		public void PrintBaseInfo()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Weight: {weight}");
		}
		public void ShowLifespan()
		{
			Console.WriteLine($"Lifespan: {lifespan}");
		}
		public void ShowWeight()
		{
			Console.WriteLine($"Weight: {weight}");
		}
		public void Feeding(string food)
		{
			if (food == "carrot")
			{
				Console.WriteLine("Your pet has just eaten");
			}
			else
			{
				Console.WriteLine("Your pet has just eaten and gained some weight");
				weight += 0.2;
			}
		}
		public void Running()
		{
			Console.WriteLine("Your pet has exercised");
			weightloss -= 0.1;
		}
	}
	class Hamster : Animal
	{
		public int foodIntakeCount = 0;
		public double levelOfHappiness = 0;

		public void FeedingHamster(string food)
		{
			if (food == "carrot")
			{
				Console.WriteLine("Your pet has just eaten");
				levelOfHappiness -= 0.1;
			}
			else
			{
				Console.WriteLine("Your pet has just eaten and gained some weight");
				levelOfHappiness += 0.2;
				weight += 0.2;
			}
		}
		public void ShowNumberOfFoodIntakes()
		{
			Console.WriteLine($"{name} has now {foodIntakeCount} number of food intakes.");
		}
		public void ShowlevelOfHappiness()
		{
			Console.WriteLine($"Level of happiness is: {levelOfHappiness}.");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Hamster nunnu = new Hamster();
			nunnu.name = "Nunnu";
			nunnu.age = 0;
			nunnu.weight = 0.1;
			nunnu.lifespan = 10;

			nunnu.PrintBaseInfo();

			for (int i = 0; i < nunnu.lifespan; i++)
			{
				nunnu.age++;
				Console.WriteLine("what would you like to feed to your pet? Carrot/bread");
				string food = Console.ReadLine();
				nunnu.FeedingHamster(food);
				nunnu.ShowWeight();

				if (nunnu.weight > 0.7)
				{
					nunnu.Running();
				}

				if (nunnu.levelOfHappiness < -0.1)
				{
					Console.WriteLine("Your pet is unhappy, feed him something else");
					nunnu.ShowlevelOfHappiness();
				}
			}
			Console.WriteLine("End of for loop");
			nunnu.PrintBaseInfo();

			if (nunnu.age == nunnu.lifespan)
			{
				Console.WriteLine("Sorry, your lifetime is over!");
				nunnu = null;
			}
			Console.ReadLine();
		}
	}
}
