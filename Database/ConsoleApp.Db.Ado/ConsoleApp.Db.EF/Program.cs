namespace ConsoleApp.Db.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = "N";
            do
            {
                DbOperation();

                Console.WriteLine("do you want to continute more(Y/N)?");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        static void DbOperation()
        {
            Console.WriteLine("Press\n1 to Read all the data\n2 to Read data by ID\n3 to Create the Record\n4 to Update the Record\n5 to Delete the Record");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                   
                    break;
                case 2:
                   
                    break;
                case 3:
                  
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}