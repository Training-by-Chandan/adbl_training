using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //class
    //blueprint
    //design

    //object : instance of a class
    public class HumanBeing
    {
        //constructor
        //special function which
        //1. Runs only once in its lifetime
        //2. It has the same name as that of class name
        //3. It does not have any return type
        //4. Access modifiers : public, private (in some cases), protected (inheritence), static (in static classes)
        //5. can have multiple constructors (constructor overloading)
        //default constructors
        //public HumanBeing()
        //{
        //}

        ////parameterless constructor
        public HumanBeing()
        {
            //do some work here
            int i = 10;
            Name = "Babu";
        }

        public HumanBeing(string name)
        {
            Name = name;
        }

        public HumanBeing(string name, string address)
        {
            Name = name;
        }

        public HumanBeing(int i)
        {
            int x = i;
            Name = "Babu";
        }

        //access modifiers
        //1. public
        //2. private
        //3. protected
        //4. internal
        //5. internal protected

        //variables

        public string Name;
        public string Age;
        public string Profession;

        //properties
        //methods/functions/actions
        //destructor : not often used; instead we use GC
        //delegates
        //events
    }

    public class Motorbike
    {
    }

    public class Employee
    {
        //constructor
        public Employee(string fname, string lname)
        {
            _fname = fname;
            _id = Random.Shared.Next();
            _email = fname + "@adb.com";
            _lname = lname;
        }

        //variables: _, a-z, A-Z, 0-9
        private string _fname;

        private string _lname;

        private int _id;
        private string _email;

        //properties
        //public int Id
        //{
        //    get { return _id; }
        //}

        public int Id => _id;

        public string FullName
        {
            //get { return string.Format("{0} {1}", _fname, _lname); }
            //get { return $"{_fname} {_lname}"; }
            get { return _fname + " " + _lname; }
        }

        public string Intials
        {
            get
            {
                string first = _fname[0].ToString();
                string second = _lname[0].ToString();
                return first + second;
            }
        }
    }

    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //}

    public class StudentInfo
    {
        //property
        //public float MathMarks { get; set; }

        //full property
        private float _math;

        public float Math
        {
            get { return _math; }
            set
            {
                if (value > 100)
                {
                    _math = 100;
                }
                else if (value < 0)
                {
                    _math = 0;
                }
                else
                {
                    _math = value;
                }
            }
        }

        private float _science;

        public float Science
        {
            get
            {
                return _science;
            }
            set
            {
                if (value > 100)
                {
                    _science = 100;
                }
                else if (value < 0)
                {
                    _science = 0;
                }
                else
                {
                    _science = value;
                }
            }
        }

        //readonly property : because it only has get
        public float Total
        {
            get { return Science + Math; }
        }

        public float Percentage
        {
            get { return Total / 2; }
        }

        public string Division
        {
            get
            {
                if (Percentage >= 80)
                {
                    return "Distinction";
                }
                else if (Percentage >= 60)
                {
                    return "First Division";
                }
                else if (Percentage >= 45)
                {
                    return "Second Division";
                }
                else if (Percentage >= 32)
                {
                    return "Third Division";
                }
                else
                {
                    return "Failed";
                }
            }
        }

        //functions
        //signatue : float ()
        public float TotalMarks()
        {
            return Science + Math;
        }

        //signatue void (int,int)
        public void Add(int a, int b)
        {
            //return; : return is also used when we need the function to break the execution
            int result = a + b;

            Console.WriteLine($"result = {result}");
        }

        //functon  : a set procedure to do a task with input and/or output(based on return type)

        public void Add()
        {
            //we will do something
        }
    }

    public class Maths
    {
        public Maths()
        {
            //only in rare cases, normally we dont do it
            //return;
        }

        //function overloading : Name of the function is same but signature  should be different
        public int Add(int a)
        {
            return a + 1;
        }

        //public int Add(int a, int b) => a + b;
        //public int Add(int a, int b) { return a + b; }
        public int Add(int a, int b)
        {
            //do something
            return a + b;
        }

        public int Add(int x, float y)
        {
            //something
            return x + (int)y;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public void FunctionOne(int a, string b, int c)
        {
            //do something
            return;
        }

        public void FunctionOne(string b, int a, int c)
        {
            //do something
        }

        public void FunctionTwo(string b, int a, int c)
        {
            //do something
        }

        public void PassByValue(int x, int y)
        {
            x++;
            y++;
        }

        public void PassByReference(ref int a, ref int b)
        {
            a++;
            b++;
            a = a + b;
        }

        public void PassbyOut(int a, int b, out int res)
        {
            res = a + b;
        }

        public string FnThree(int a, int b, out int res)
        {
            res = a + b;
            return "Everything is good";
        }
    }
}