namespace CentsCounter
{
	using System;
	
	class CounterProgra
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Cents Counter");
			
			
			decimal quarters = 0.0M;
			while(true)
			{ 
				Console.Write("Please enter number of quarters: ");
				string inputQts = Console.ReadLine();
				try{
				 quarters = Convert.ToDecimal(inputQts);
					break;
				}
				catch (FormatException e)
				{
					Console.WriteLine("There was an error: "+ e.Message+"\nTry Again");
				}
				catch(Exception e2)
				{
					Console.Write("BAD");
				}
			}
			
			
			Console.Write("Please enter number of dimes: ");
			string inputDimes = Console.ReadLine();
			
			Console.Write("Please enter number of nickels: ");
			string inputNickels = Console.ReadLine();
			
			Console.Write("Please enter number of pennies: ");
			string inputPennies = Console.ReadLine();
			
			// convertions:
			decimal dimes = Convert.ToDecimal(inputDimes);
			decimal nickels = Convert.ToDecimal(inputNickels);
			decimal pennies = Convert.ToDecimal(inputPennies);
			
			decimal totalpennies = (quarters * 25) + (dimes * 10) +
				(nickels * 5) + pennies;
			
			Console.WriteLine("You have "+totalpennies + " pennies");
			
			decimal dollars = totalpennies / 100;
			
			Console.WriteLine("$"+dollars.ToString().Substring(0,4));
			
		}
	}
}

