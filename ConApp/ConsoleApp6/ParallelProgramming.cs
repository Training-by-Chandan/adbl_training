using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ParallelProgramming
    {
        public async void Run()
        {
            //FunctionOne();
            //FunctionTwo();
            //Console.WriteLine("====================================");
            //Thread t1 = new Thread(FunctionOne);
            //Thread t2 = new Thread(FunctionTwo);

            //t1.Start();
            //t2.Start();

            ////Task
            //Task task1 = new Task(FunctionOne);
            //Task Task2 = new Task(FunctionTwo);
            //task1.Start();
            //Task2.Start();

            //Task<string> task3 = new Task<string>(FunctionThree);
            //Task<int> task4 = new Task<int>(FunctionFour);

            //task3.Start();
            //task4.Start();

            //var res3 = task3.Result;
            //var res4 = task4.Result;

            //FunctionThree();
            //FunctionFour();

            var res = FunctionFive(10);
            var res2 = FunctionSix(15);

            Console.WriteLine($"Function Six return {res2.Result}");
            Console.WriteLine($"Function Five return {res.Result}");
        }

        public void FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function One Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //return 1;
        }

        public void FunctionTwo()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Function Two Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public string FunctionThree()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function Three Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return "Function 3 is completed";
        }

        public int FunctionFour()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Function Four Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return 100;
        }

        public async Task<string> FunctionFive(int x)
        {
            for (int i = 0; i < x; i++)
            {
                await Task.Delay(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function Five Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return "Function 5 is completed";
        }

        public async Task<int> FunctionSix(int x)
        {
            for (int i = 0; i < x; i++)
            {
                await Task.Delay(1000);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Function Six Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return 100;
        }
    }
}