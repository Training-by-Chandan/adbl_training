namespace ConsoleApp6
{
    //static class
    public static class StaticClass
    {
        //static class are those class with self object. which means we cannot create new objects
        //every members are static (mandatory)
        static StaticClass()
        {
        }

        public static int i = 10;
        public static int number { get; set; }

        public static void FunctionOne()
        {
            i++;
            number++;
        }
    }

    //normal class
    public class NonStaticClass
    {
        //members may be / may not be static
        //the non statc memebrs are accessed by individual objects
        //static members cannot access nonstatic members, but non static memebrs can access static members
        public int i = 10;

        public int number { get; set; }

        public void FunctionOne()
        {
            i++;
            iStatic++;
            //StaticFunctionOne();
        }

        //the static membes are shared ones, it can be accessed by any objects
        public static int iStatic;

        public static int numberStatic { get; set; }

        public static void StaticFunctionOne()
        {
            // i++;
            iStatic++;

            NonStaticClass n = new NonStaticClass();
            n.FunctionOne();
        }
    }
}