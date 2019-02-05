using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	public class Problems
	{
		public static void MultiplesOf3And5()
		{
			Console.WriteLine("Find the sum of all the multiples of 3 and 5 below a limit. Input a limit");
			if(Int64.TryParse(Console.ReadLine(), out long limit))
			{
				long result = MultiplesOf3And5(limit);
				Console.WriteLine($"The sum is {result}");
			}
			else
			{
				Console.WriteLine($"Invalid input. Make sure you input is an number. The maximum we can accept is {long.MaxValue}");
			}
		}

		/// <summary>
		/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
		/// Find the sum of all the multiples of 3 or 5 below 1000.
		/// </summary>
		/// <param name="limit"></param>
		/// <returns></returns>
		private static long MultiplesOf3And5(long limit)
		{
			
			long currentSum = 0;
			for(long i = 2; i <  limit; i++)
			{
				if(i%3==0 || i % 5 == 0)
				{
					currentSum += i;
				}
			}
			return currentSum;
		}

	}
}
