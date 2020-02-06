using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var root in Tests.FindRootsOfSquareEquation(6,15,0))
            {
                Console.WriteLine(root);
            }
            Console.ReadKey();
        }
    }
}
