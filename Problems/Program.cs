using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Problems.EvenFibonacciNumbers();

			// Keeps console open on debug mode
			KeepConsoleOpen();
		}
		public static void KeepConsoleOpen()
		{
			#if DEBUG
				Console.WriteLine("Press enter to close...");
				Console.ReadLine();
			#endif
		}
	}
}
