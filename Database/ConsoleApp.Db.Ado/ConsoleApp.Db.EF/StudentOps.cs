namespace ConsoleApp.Db.EF
{
    public static class StudentOps
    {
        private static DatabaseContext db=new DatabaseContext();
        public static void ReadAll()
        {
            var data = db.Students;
            foreach (var item in data)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"FirstName : {item.FirstName}");
                Console.WriteLine($"LastName : {item.LastName}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine("=========================================");
            }
        }

        public static void ReadById()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing==null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                Console.WriteLine($"Id : {existing.Id}");
                Console.WriteLine($"FirstName : {existing.FirstName}");
                Console.WriteLine($"LastName : {existing.LastName}");
                Console.WriteLine($"Email : {existing.Email}");
            }
        }
        public static void Create()
        {
            var student = new Student();
            Console.WriteLine("Enter the first name");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter the email");
            student.Email = Console.ReadLine();

            db.Students.Add(student);
            db.SaveChanges();
        }
        public static void Edit()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing==null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                Console.WriteLine("Enter the first name");
                existing.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the last name");
                existing.LastName = Console.ReadLine();
                Console.WriteLine("Enter the email");
                existing.Email = Console.ReadLine();

                db.Students.Update(existing);
                db.SaveChanges();
            }
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing == null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                db.Students.Remove(existing);
                db.SaveChanges();
            }
        }
    }
}