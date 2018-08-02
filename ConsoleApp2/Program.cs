using System;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push("some string");
            stack.Push(3);

            try
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(stack.Clear());

            var stack2 = new Stack();
            Console.WriteLine(stack2.Clear());
        }
    }
}
