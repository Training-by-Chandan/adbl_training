namespace ConsoleApp6
{
    //interface : contract / like specification
    public interface IAbc
    {
        int I { get; set; }

        void Add();

        int Test();

        int Add(int a, int b);
    }

    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IGetInput
    {
        void GetInput();
    }

    public interface IShape : IArea, IPerimeter, IGetInput
    {
    }

    public class Square : IShape
    {
        public void Area()
        {
        }

        public void Perimeter()
        {
        }

        public void GetInput()
        {
        }

        public void FunctionOne()
        {
        }

        private void FunctionTwo()
        {
        }
    }

    public class Rectangle : IShape
    {
        public void Area()
        {
            throw new System.NotImplementedException();
        }

        public void GetInput()
        {
            throw new System.NotImplementedException();
        }

        public void Perimeter()
        {
            throw new System.NotImplementedException();
        }

        public void FunctionThree()
        {
        }

        private void FunctionFour()
        {
        }
    }
}