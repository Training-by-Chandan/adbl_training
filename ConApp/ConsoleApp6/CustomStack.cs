using System;

namespace ConsoleApp6
{
    public class CustomStack
    {
        private string[] container = new string[0];

        public void Push(string item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        public void Pop()
        {
            if (container.Length > 0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
        }
    }
}