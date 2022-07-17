using System;

namespace ConsoleApp6
{
    //interface : contract / like specification
    public interface IAbc
    {
        int I { get; set; }

        void Add();

        int Test();

        int Add(int a, int b);
    }

    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IGetInput
    {
        void GetInput();
    }

    public interface IShape : IArea, IPerimeter, IGetInput
    {
    }

    public class Square : IShape
    {
        private double length;

        public void Area()
        {
            var area = Math.Pow(length, 2);
            Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            var perimeter = 4 * length;
            Console.WriteLine($"Perimeter = {perimeter}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void FunctionOne()
        {
        }

        private void FunctionTwo()
        {
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double breadth;

        public void Area()
        {
            var area = length * breadth;
            Console.WriteLine($"Area = {area}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 2 * (length + breadth);
            Console.WriteLine($"Perimeter = {perimeter}");
        }

        public void FunctionThree()
        {
        }

        private void FunctionFour()
        {
        }
    }

    public class Circle : IShape
    {
        public void Area()
        {
        }

        public void GetInput()
        {
        }

        public void Perimeter()
        {
        }
    }
}