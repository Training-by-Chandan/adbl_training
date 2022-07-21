using System;

namespace ConsoleApp6
{
    public class Delegates
    {
        //delegate : pointer to function
        public delegate void MathOps(int a, int b);

        public void Run()
        {
            //Unicast();
            MultiCast();
        }

        private void MultiCast()
        {
            int i = 10;
            i = i + 5;
            string s = "abc";
            s = s + "def";

            MathOps m = Add;
            m = m + Multiply + Subtract + Add + Divide;
            //m(2, 3);

            m += Multiply;
            m += Divide;
            m(2, 3);

            m -= Add;
            m(2, 3);
        }

        private void Unicast()
        {
            MathOps m = Add;
            m(2, 3);

            m = Subtract;
            m(2, 3);

            m = Multiply;
            m(2, 3);

            m = Divide;
            m(2, 3);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Difference = {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Product = {x * y}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"Quotient = {x / y}");
        }
    }
}