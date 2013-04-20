using System;

namespace CarReview
{
	class MainClass
	{
		public static void Main ()
		{
			Console.Write("Please type your car make: ");
			string make = Console.ReadLine();
			
			/* jfbkadfnkjdsgn,fngb,fnblxc
			if(make.ToLowerInvariant() == "honda"){
				Console.WriteLine("Car is good!");
			}
			else if (make.ToLowerInvariant() == "nissan")
			{
				Console.Write("car is so-so");
			}
			else if (make.ToLowerInvariant() == "hyundai")
			{
				Console.Write("car is whatever");				
			}
			else {
				Console.WriteLine("your car is bad");
			}
			*/
			
			//This program read input etc tec
			
			switch(make.ToLowerInvariant())
			{
				case "honda" : Console.WriteLine("honda");
					break;
					
				case "nissan" : 
				{
					Console.WriteLine();
					break;
				}
			default: Console.WriteLine("default!");
				
			}
			
			
		}
		
		
	}
}

