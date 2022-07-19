using System;

namespace ConsoleApp6
{
    public class FirstClass
    {
        public string VariableOne { get; set; }
        public string VariableTwo { get; set; }
    }

    public class SecondClass
    {
        public int VariableOne { get; set; }
        public int VariableTwo { get; set; }
    }

    public class ThirdClass
    {
        public LivingThings VariableOne { get; set; }
        public LivingThings VariableTwo { get; set; }
    }

    public class GenericClass<A, B>
        where A : LivingThings
        where B : IShape
    {
        public A VariableOne { get; set; }
        public A VariableTwo { get; set; }
        public B VariableThree { get; set; }
        public B VariableFour { get; set; }
    }

    public class NonGenericClass
    {
        public void FunctionOne<T1, T2>(T1 item1, T2 item2, T1 item3)
        {
        }
    }
}