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

        public void Eat()
        {
            //PrivateFunction();
            System.Console.WriteLine("All living things eat");
        }
    }
}