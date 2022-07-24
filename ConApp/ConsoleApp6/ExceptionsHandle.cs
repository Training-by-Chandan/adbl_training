using System;

namespace ConsoleApp6
{
    public class ExceptionsHandle
    {
        public static void FunctionOne()
        {
            FunctionTwo();
        }

        public static void FunctionTwo()
        {
            Add();
        }

        public static void Add()
        {
            Console.WriteLine("Enter the first number");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[5];
            arr[5] = 10;

            if (num == 10)
            {
                throw new Number10Exception("The first number cannot be ten");
            }
            if (num == 5)
            {
                throw new Number5Exception();
            }
        }
    }

    public class Number5Exception : Exception
    {
        public Number5Exception() : base("Number cannot be 5")
        {
        }
    }

    [Serializable]
    public class Number10Exception : Exception
    {
        public Number10Exception()
        { }

        public Number10Exception(string message) : base(message)
        {
        }

        public Number10Exception(string message, Exception inner) : base(message, inner)
        {
        }

        protected Number10Exception(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}