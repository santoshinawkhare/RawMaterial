using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GenericEx find = new GenericEx();
            find.intMaximum(10, 20, 30);
        }
    }
}
