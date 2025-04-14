using System;

namespace ClassLibrary1
{
    public class Sample
    {
        // target method
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of {a} and {b} is: {a + b}");
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} and {b} is: {a * b}");
        }
    }

}
