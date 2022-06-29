using System;

namespace ABC.App
{
    public class Program
    {
        private static void Main()
        {
            //Basic();
            DataTypes();
        }

        private static void DataTypes()
        {
            //integer data
            //int = Int32 => 32 bit number
            int i = -1; //signed number; can take both positive and negative numbers
            int j = 2000000000;
            int result = i + j;
            uint ui = 1; //unsigned int (32 bit number) ; can only take positive numbers

            //int16 bit ; short => 16 bit integer data
            short s = 32000; //signed number of 16 bit integer data
            ushort us = 65535;//unsigned number of 16 bit

            //int64 ; long => 64 bit of integer data
            long l = 1000000000000000000;
            ulong ul = 1;

            float f = 2.02f;
            double d = 2.05d;
            decimal dec = 2.05m;

            bool b = true;
            char c = 'a';
            string str = "djafhgsdfhajsdfasdfsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgasdf";

            DateTime dt = DateTime.Now;
        }

        private static void Basic()
        {
            Console.WriteLine("Hello, Agriculture Development Bank!");
            Console.WriteLine("Enter the name");
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }
    }
}