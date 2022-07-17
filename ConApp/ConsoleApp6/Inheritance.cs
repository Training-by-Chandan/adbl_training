namespace ConsoleApp6
{
    public class LivingThings
    {
        public int I;

        public string Name { get; set; }

        public void PublicFunction()
        {
            System.Console.WriteLine("We are public function");
        }

        private void PrivateFunction()
        {
            System.Console.WriteLine("I am private function");
        }

        protected void ProtectedFunction()
        {
            System.Console.WriteLine("We are protected members");
        }

        public virtual void Eat()
        {
            //PrivateFunction();
            System.Console.WriteLine("All living things eat");
        }

        //types
        //1. Single Inheritence
        //2. Multiple Inheritence (by the help of interface)
        //3. Multi-Level Inheritence
        //4. Hierarchial Inheritence
        //5. Hybrid Inheritence

        //polymorphism : One function with many forms
    }
}