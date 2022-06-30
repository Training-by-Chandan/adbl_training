using System;

namespace ABC.App
{
    public class Program
    {
        private static void Main()
        {
            //Basic();
            //DataTypes();
            //Casting();
            CastingExample();
        }

        private static void CastingExample()
        {
            Console.WriteLine("Enter the length");
            string lengthStr = Console.ReadLine();
            Console.WriteLine("Enter the breadth");
            string breadthStr = Console.ReadLine();

            int length = Convert.ToInt32(lengthStr);
            int breadth = Convert.ToInt32(breadthStr);
            int area = length * breadth;
            int perimeter = 2 * (length + breadth);
            Console.WriteLine("Area is " + area);
            Console.WriteLine("Perimeter is " + perimeter);
        }

        //casting  : changing from one datatype to another datatype
        private static void Casting()
        {
            //char => int => long => float => double
            //-->---->----->----implicit casting---->------>------->
            //<-----<-----<-----explicit casting<-----<-----<------<

            //implicit : automatic casting
            char c = 'C';
            int i = c;// 67
            long l = i;
            float f = l;
            double d = f;

            //explicit : manual casting
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;

            //every types can be converted into string types or object types
            string str = c.ToString();
            str = i.ToString();
            str = l.ToString();
            str = f.ToString();

            object o = str;
            o = i;
            o = c;
            o = f;
            o = l;
            str = o.ToString();

            //Parsing
            str = "2.02";
            f = float.Parse(str);
            str = "1";
            i = int.Parse(str);

            //type conversion class
            i = Convert.ToInt32(f);
            i = Convert.ToInt32("123");

            var j = "adfasd";
            j = "";
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
            string str = "10";

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