using System;

namespace ConsoleApps
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello by min");
        }

        //todo  to be done by chandan
    }

    public interface IAbc
    {
        int I { get; set; }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}