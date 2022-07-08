using ConsoleApp6;
using System;
using System.Text;

namespace ABC.App
{
    public class Program
    {
        private static void Main()
        {
            var res = "y";
            do
            {
                //Basic();
                //DataTypes();
                //Casting();
                //CastingExample();
                //ConditionExample1();
                //ConditionExample3();
                //ConditionExample2();
                //ConditionExample4();
                //LoopingV2();
                //Concatenation();
                //ArrayAndLoopingExample();
                //ClassAndObjectsExample();
                //PropertiesExample();
                //PropertiesExampleV2();
                FunctionExample();

                Console.WriteLine("Do you want to continue more?(y/n)");
                res = Console.ReadLine();
            } while (res == "y");
        }

        private static void FunctionExample()
        {
            Maths m = new Maths();
            var res1 = m.Add(10);
            m.Add(10, 12);
            m.Add(10, 12);
            m.Add(10, 12);
            m.Add(10, 12);

            m.Add(12, 13f);
            m.FunctionOne(1, "Chandan", 12);
            m.FunctionOne("Chandan", 12, 15);

            m.FunctionTwo("abc", 12, 15); //normal
            //advance cases:
            m.FunctionTwo(b: "", a: 12, c: 15);
            m.FunctionTwo(c: 15, b: "", a: 12);

            m = new Maths();
            int a = 12;
            int b = 13;
            //pass by value
            m.PassByValue(a, b);
            m.PassByReference(ref a, ref b);
            int result = 0;
            m.PassbyOut(a, b, out result);
        }

        private static void PropertiesExampleV2()
        {
            StudentInfo si = new StudentInfo();
            si.Math = 70;
            si.Science = 80;
            Console.WriteLine($"Science = {si.Science}");
            Console.WriteLine($"Math = {si.Math}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Total = {si.Total}");
            Console.WriteLine($"Percentage = {si.Percentage}");
            Console.WriteLine($"Division = {si.Division}");
            Console.WriteLine();
            Console.WriteLine();

            si.Math = 60;
            si.Science = 40;
            Console.WriteLine($"Science = {si.Science}");
            Console.WriteLine($"Math = {si.Math}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Total = {si.Total}");
            Console.WriteLine($"Percentage = {si.Percentage}");
            Console.WriteLine($"Division = {si.Division}");
            Console.WriteLine();
            Console.WriteLine();

            //si.Add(10);
        }

        private static void PropertiesExample()
        {
            StudentInfo si = new StudentInfo();
            si.Math = 109;
            Console.WriteLine("Assigning Math = 109");
            Console.WriteLine($"Value of Math is {si.Math}");
            Console.WriteLine();
            si.Math = -109;
            Console.WriteLine("Assigning Math = -109");
            Console.WriteLine($"Value of Math is {si.Math}");
            Console.WriteLine();
            si.Math = 19;
            Console.WriteLine("Assigning Math = 19");
            Console.WriteLine($"Value of Math is {si.Math}");
            Console.WriteLine();
        }

        private static void ClassAndObjectsExample()
        {
            Employee shanti = new Employee("shanti", "rijal");
            Employee shrijana = new Employee("shrijana", "paudel");

            Console.WriteLine(shanti.Id);
            Console.WriteLine(shanti.FullName);
            Console.WriteLine(shanti.Intials);
            //Console.WriteLine(shanti.Email);

            //shanti.Id = Random.Shared.Next();
            //shanti.Name = "Shanti Rijal";

            Console.WriteLine(shrijana.Id);
            Console.WriteLine(shrijana.FullName);
            Console.WriteLine(shrijana.Intials);

            //shrijana.Id = Random.Shared.Next();
            //shrijana.Name = "Shrijana Paudel";
            int i = 12;

            //HumanBeing chandan = new HumanBeing();
            //HumanBeing sh = new HumanBeing();
            //HumanBeing amin = new HumanBeing();
            //HumanBeing h1 = new HumanBeing();
            //chandan.Name = "Chandan Bhagat";
            //sh.Name = "Shanti Rijal";
            //chandan.Profession = "Software Engineer";

            //shanti.Name = "Shanti Rijal";
            //shanti.Profession = "Banker";

            //Console.WriteLine(chandan.Age);
            //Console.WriteLine(shanti.Name);
            //Console.WriteLine(amin.Name);
            //Console.WriteLine(h1.Name);

            //Motorbike chandanbike = new Motorbike();
        }

        private static void ArrayAndLoopingExample()
        {
            int[] intArr = new int[5];
            //index starts from 0
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i + 1;
            }

            foreach (int item in intArr)
            {
                Console.WriteLine(item);
            }
        }

        private static void Concatenation()
        {
            //concatenation
            string str1 = "Chandan";
            string str2 = "Bhagat";
            string result = str1 + " " + str2;
            Console.WriteLine(result);

            //string formatting
            string templ = "{0} {1}";
            string result2 = string.Format(templ, str1, str2);
            string result3 = string.Format("{0} 1", str1, str2);

            Console.WriteLine(result2);
            Console.WriteLine(result3);

            //string interpolation
            var result4 = $"{str1} asdfasdf {str2}";

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear Sir");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");

            Console.WriteLine(sb.ToString());
        }

        private static void LoopingV2()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }

        private static void Looping()
        {
            //for unknown parameters
            //while
            //do --- while

            //for known parameters
            //for
            //foreach
        }

        private static void ConditionExample4()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            var remainder = num % 2;
            string resut = "";
            if (remainder == 0)
            {
                resut = "It is a even number";
            }
            else
            {
                resut = "It is a odd number";
            }
            //ternar operator
            //syntax :
            // (condition) ? <true statement> : <false statement>
            resut = (remainder == 0) ? "It is a even number" : "It is a odd number";
            Console.WriteLine(resut); ;
        }

        private static void ConditionExample3()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }

            switch (num)
            {
                case 1:
                case 7:
                    Console.WriteLine("Its a weekend");
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Its a weekdays");
                    break;

                default:
                    break;
            }
        }

        private static void ConditionExample2()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }

            if (num == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (num == 2)
                Console.WriteLine("Monday");
            else if (num == 3) Console.WriteLine("Tuesday");
            else if (num == 4) Console.WriteLine("Wednesday");
            else if (num == 5) Console.WriteLine("Thursday");
            else if (num == 6) Console.WriteLine("Friday");
            else if (num == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Not a valid day");

            if (num == 1 || num == 7)
            {
                Console.WriteLine("Its a weekend");
            }
            else if (num == 2 || num == 3 || num == 4 || num == 5 || num == 6)
            {
                Console.WriteLine("Its a weekdays");
            }
            else
            {
                Console.WriteLine("not a valid day");
            }
        }

        private static void ConditionExample1()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            var remainder = num % 2;
            if (remainder == 0)
            {
                Console.WriteLine("It is a even number");
            }
            else
            {
                Console.WriteLine("It is a odd number");
            }
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