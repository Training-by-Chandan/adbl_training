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
}