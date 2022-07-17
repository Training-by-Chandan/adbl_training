namespace ConsoleApp6
{
    public class Animal : LivingThings
    {
        public void FunctionOne()
        {
            I = 20;
            PublicFunction();
            //PrivateFunction();
            ProtectedFunction();
        }

        //in order to do override, the base function should be wither of virtual, override or abstract
        public override void Eat()
        {
            System.Console.WriteLine("animal can eat");
        }
    }
}