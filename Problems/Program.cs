using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Program
	{
        static Problems  _problem = new Problems();
		
		public static void Main(string[] args)
		{
            // Establish an event handler to process key press events.
            Console.CancelKeyPress += new ConsoleCancelEventHandler(MyHandler);

            while (true)
            {
                _problem.LargestPrimeFactor();
            }

            // Keeps console open on debug mode
            //KeepConsoleOpen();
		}
		public static void KeepConsoleOpen()
		{
			#if DEBUG
				Console.WriteLine("Press enter to close...");
				Console.ReadLine();
			#endif
		}

        protected static void MyHandler(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("\nThe read operation has been interrupted.");

            Console.WriteLine("  Key pressed: {0}", args.SpecialKey);

            Console.WriteLine("  Cancel property: {0}", args.Cancel);

            // Set the Cancel property to true to prevent the process from terminating.
            Console.WriteLine("Setting the Cancel property to true...");
            args.Cancel = true;

            // Announce the new value of the Cancel property.
            Console.WriteLine("  Cancel property: {0}", args.Cancel);
            Console.WriteLine("The read operation will resume...\n");
        }
    }
}
