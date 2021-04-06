using System;

namespace Stackqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Intstack mystack = new Intstack();
            mystack.Push(10);
            System.Console.WriteLine(mystack.Pop());

            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);

            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.Pop());

            System.Console.ReadKey();

        }
    }
}
