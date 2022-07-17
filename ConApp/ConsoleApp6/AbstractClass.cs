using System;

namespace ConsoleApp6
{
    //class but we cannot create the object out it
    public abstract class AbstractClass
    {
        public int I = 10;

        public void FunctionOne()
        {
            System.Console.WriteLine("Function One");
        }

        public abstract void FunctionTwo();
    }

    public class ClassOne : AbstractClass
    {
        public override void FunctionTwo()
        {
            FunctionOne();
            System.Console.WriteLine("Function Two");
        }
    }

    public abstract class ShapeAbs
    {
        protected double area;
        protected double perimeter;

        public void Area()
        {
            System.Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            System.Console.WriteLine($"Perimeter = {perimeter}");
        }

        public abstract void GetInput();

        protected abstract void Calculate();
    }

    public class SquareAbs : ShapeAbs
    {
        private double length;

        public override void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Calculate();
        }

        protected override void Calculate()
        {
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        private double length;
        private double breadth;

        public override void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
            Calculate();
        }

        protected override void Calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }
}