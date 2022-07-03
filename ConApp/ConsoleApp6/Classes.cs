using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //blueprint
    //design
    //class
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

        //properties
        //methods/functions/actions
        //destructor : not often used; instead we use GC
        //delegates
        //events
    }

    public class Motorbike
    {
    }
}