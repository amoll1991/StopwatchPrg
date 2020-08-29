using System;

namespace StopwatchPrg
{
    class StopWatchModel
    {
       
        static void Main(string[] args)
        {
            int choice;
            StopWatch SW = new StopWatch();
            
            
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Your Choice:");
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SW.Start();
                        break;
                    case 2:
                        SW.Stop();
                        Console.WriteLine("Time Span:{0}",SW.GetInterval());
                        break;
                    case 3: System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice. Please try again...");
                        break;
                }
            } while(true);

            
            
        }
    }
}
