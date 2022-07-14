namespace ConsoleApp6
{
    public class Plant : LivingThings
    {
        public class PrivateClass
        {
        }

        private class NewClass
        {
        }

        public void Eat()
        {
            System.Console.WriteLine("Plants do photosynthesis");
        }
    }
}