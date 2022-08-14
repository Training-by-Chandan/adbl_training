using System.Data.SqlClient;

namespace ConsoleApp.Db.Ado
{
    public static class DbConnection
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-PT71T7O\\SQLBHAGAT;Initial Catalog=Adb.Console.Ado;integrated security=true;";

        public static void ReadAll()
        {
            ///1. Create the query
            string query = "select * from Person";

            ReadData(query);
        }

        public static void ReadById()
        {
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();
            ///1. Create the query
            string query = $"select * from Person where id = {id}";

            ReadData(query);
        }

        public static void Create()
        {
            Console.WriteLine("Enter the First Name");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            var lname = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            var email = Console.ReadLine();
            ///1. Create the query
            string query = $"Insert into Person (FirstName, LastName,Email) values  ('{fname}','{lname}','{email}')";

            ExecuteNonQuery(query);
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();
            Console.WriteLine("Enter the First Name");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            var lname = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            var email = Console.ReadLine();
            ///1. Create the query
            string query = $"update Person set FirstName = '{fname}', LastName ='{lname}', Email = '{email}' where id={id}";

            ExecuteNonQuery(query);
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();
          
            ///1. Create the query
            string query = $"delete from Person where id={id}";

            ExecuteNonQuery(query);
        }


        private static void ReadData(string query)
        {
            ///2. Create the Sql Connection Object using the connectionstring
            SqlConnection con = new SqlConnection(_connectionString);

            ///3. Using the connection object and query, we will create the sql command object
            SqlCommand cmd = new SqlCommand(query, con);

            ///4. Open the connection
            con.Open();

            ///5. Run the command
            var reader = cmd.ExecuteReader();

            ///6. Do the processing
            Console.WriteLine("Data From the table Person");
            Console.WriteLine("======================================");
            while (reader.Read())
            {
                Console.WriteLine($"Id : {reader.GetFieldValue<int>(0)}");
                Console.WriteLine($"First Name : {reader.GetFieldValue<string>(1)}");
                Console.WriteLine($"Last Name : {reader.GetFieldValue<string>(2)}");
                Console.WriteLine($"Email : {reader.GetFieldValue<string>(3)}");
                Console.WriteLine("======================================");
            }

            ///7. Close the connection
            con.Close();
        }

        private static void ExecuteNonQuery(string query)
        {
            ///2. Create the Sql Connection Object using the connectionstring
            SqlConnection con = new SqlConnection(_connectionString);

            ///3. Using the connection object and query, we will create the sql command object
            SqlCommand cmd = new SqlCommand(query, con);

            ///4. Open the connection
            con.Open();

            ///5. Run the command
             cmd.ExecuteNonQuery();

            ///7. Close the connection
            con.Close();
        }
    }
}