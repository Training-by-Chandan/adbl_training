﻿using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Security.Cryptography;

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
                //FunctionExample();
                //StaticAndNonStaticExample();
                //ArrayExample();
                //InheritanceExample();
                //WithoutUsingInterfaceExample();
                //UsingInterfaceExample();
                //DelegateExample();
                //ParallelProgrammingExample();
                //ExceptionHandlingExample();
                //StreamExample();
                //EnumsExample();
                //StackImplementation();
                //QueueImplementation();
                LinkedListImplementation();

                Console.WriteLine("Do you want to continue more?(y/n)");
                res = Console.ReadLine();
            } while (res == "y");
        }

        private static void RegularExpressions()
        {
            //string pattern match
            //abc@abc.com
            string email = "abc@abc.com";
            string str = "facebook.com";
        }

        private static void LinkedListImplementation()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            var first = linkedList.AddFirst("First");
            var last = linkedList.AddLast("Last");
            var second = linkedList.AddAfter(first, "Second");
            var third = linkedList.AddAfter(second, "Third");
            var fs = linkedList.AddAfter(first, "FirstSecond");
        }

        private static void QueueImplementation()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amin Duwal");
            queue.Enqueue("Krishna Prasad Nepal");
            queue.Dequeue();
            queue.Enqueue("Rupa Shrestha");
            queue.Enqueue("Shanti Rijal");
            queue.Enqueue("Shrijana Paudel");
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue("Chandan Bhagat");
        }

        private static void StackImplementation()
        {
            Stack stack = new Stack();
            stack.Push("Book One");
            stack.Push("Book Two");
            stack.Pop();
            stack.Push("Book Three");
            stack.Push("Book Four");
            stack.Push("Book Five");
            stack.Pop();

            CustomStack cs = new CustomStack();
            cs.Push("Book One");
            cs.Push("Book Two");
            cs.Pop();
            cs.Push("Book Three");
            cs.Push("Book Four");
            cs.Push("Book Five");
            cs.Pop();

            Stack<int> stackInt = new Stack<int>();
            stackInt.Push(1);
            stackInt.Push(12);

            Stack<char> stackChar = new Stack<char>();
            stackChar.Push('C');
        }

        private static void EnumsExample()
        {
            var today = Days.Monday;
            Console.WriteLine($"String Equivalent : {today.ToString()}");
            Console.WriteLine($"Int Equivalent : {(int)today}");

            switch (today)
            {
                case Days.Monday:
                    break;

                case Days.Sunday:
                    break;

                case Days.Tuesday:
                    break;

                case Days.Wednesday:
                    break;

                case Days.Thursday:
                    break;

                case Days.Friday:
                    break;

                case Days.Saturday:
                    break;

                default:
                    break;
            }
        }

        private static void StreamExample()
        {
            var file = "D:\\TestPath\\newfile.txt";

            string str = "Hello from ADBL Batch";
            byte[] arr = Encoding.ASCII.GetBytes(str);
            using (var fs = File.Create(file)) // using should be used only with IDisposable
            {
                fs.Write(arr, 0, arr.Length);
            }

            using (var obj = new FirstClass())
            {
                obj.VariableOne = "";
                obj.VariableTwo = "";
            }
        }

        private static void ExceptionHandlingExample()
        {
            try
            {
                ExceptionsHandle.FunctionOne();
                //ExceptionGenerate();
                Console.WriteLine("Everything looks good with no error");
            }
            //catch (Number5Exception ex)
            //{
            //    //write this log in a file
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    //write code to have the log in database
            //    Console.WriteLine("Index is out of range");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format error");
            //}
            catch (Exception ex)
            {
                //send this error to the developers via mail
                Console.WriteLine($"Type of Error : {ex.GetType()}");
                Console.WriteLine(ex.Message);
                Console.WriteLine("------------------------------");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally everything stelled down");
            }
        }

        private static void ExceptionGenerate()
        {
            try
            {
                Console.WriteLine("Enter the first number");
                try
                {
                }
                catch (Exception)
                {
                    SendEmail();
                }
                var num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                var num2 = Convert.ToInt32(Console.ReadLine());

                try
                {
                    int[] arr = new int[num];
                    arr[10] = num2;
                }
                catch (Exception)
                {
                    SendEmail();
                }
            }
            catch (Exception)
            {
            }
        }

        private static void SendEmail()
        {
            //write this to file
        }

        private static void ParallelProgrammingExample()
        {
            ParallelProgramming pp = new ParallelProgramming();
            pp.Run();
        }

        private static void DelegateExample()
        {
            Delegates dg = new Delegates();
            dg.Run();
        }

        private static void GenericCollections()
        {
            List<int> list = new List<int>();
            List<string> listStr = new List<string>();
            list.Add(12);
            // list.Add("");

            listStr.Add("abc");
            // listStr.Add(12);
        }

        private static void GenericExample()
        {
            FirstClass fc = new FirstClass();
            SecondClass sc = new SecondClass();
            ThirdClass tc = new ThirdClass();

            var gc = new GenericClass<Human, Square>();

            var ng = new NonGenericClass();
            ng.FunctionOne<string, int>("", 12, "");
        }

        private static void AbstractExample()
        {
            ClassOne co = new ClassOne();
            AbstractClass abs = co;

            ShapeAbs ah = new SquareAbs();
        }

        private static void UsingInterfaceExample()
        {
            Console.WriteLine("Press 1 for square, 2 for rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());
            var shape = getShape(choice);
            if (shape != null)
            {
                shape.GetInput();
                shape.Perimeter();
                shape.Area();
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

        private static IShape getShape(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Square();

                case 2:
                    return new Rectangle();

                case 3:
                    return new Circle();

                default:
                    return null;
            }
        }

        private static void WithoutUsingInterfaceExample()
        {
            Console.WriteLine("Press 1 for square, 2 for rectangle");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                Square sq = new Square();
                sq.GetInput();
                sq.Perimeter();
                sq.Area();
            }
            else if (choice == "2")
            {
                Rectangle rt = new Rectangle();
                rt.GetInput();
                rt.Perimeter();
                rt.Area();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        private static void InheritanceExample()
        {
            int i = 'C';
            LivingThings l1 = new LivingThings();
            LivingThings a1 = new Animal();
            LivingThings p1 = new Plant();

            l1.Eat();
            a1.Eat();
            p1.Eat();

            //Plant.PrivateClass pc = new Plant.PrivateClass();

            //l1.I = 20;
            //l1.Name = "";
            //l1.PublicFunction();
            ////l1.FunctionOne();

            //a1.I = 20;
            //a1.Name = "";
            //a1.PublicFunction();
            //a1.FunctionOne();

            //p1.I = 30;
            //p1.Name = "";
            //p1.PublicFunction();
        }

        private static void ArrayExample()
        {
            int[] i = new int[10];
            i[0] = 10;
            i[4] = 4;
            i[9] = 25;

            int[] intArr = new int[] { 10, 20, 30, 45, 21 };
        }

        private static void StaticAndNonStaticExample()
        {
            // StaticClass sc = new StaticClass(); // We cannot create the objects on static class
            StaticClass.i = 10;
            StaticClass.number = 20;
            StaticClass.FunctionOne();

            NonStaticClass nsc = new NonStaticClass();
            NonStaticClass nsc1 = new NonStaticClass();
            NonStaticClass nsc2 = new NonStaticClass();
            NonStaticClass nsc3 = new NonStaticClass();

            nsc.FunctionOne();
            nsc1.FunctionOne();
            nsc2.FunctionOne();
            nsc3.FunctionOne();

            NonStaticClass.iStatic = 20;
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

            //out
            string str = "10";
            int i = Convert.ToInt32(str);
            i = int.Parse(str);
            int.TryParse(str, out i);
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