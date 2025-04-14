using System;
using ClassLibrary1;

namespace SingleCastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object of a Sample class
            Sample s = new Sample();
            // create delegate object (or) delegate
            MyDelegateType myDelegate;
            // add method reference to delegate
            myDelegate = new MyDelegateType(s.Add); // new MyDelegateType is redundant

            // invoke method using delegate object
            Console.WriteLine(myDelegate.Invoke(30, 40));
            Console.WriteLine("-------");
            myDelegate = new MyDelegateType(s.Subtract); // new MyDelegateType is redundant
            Console.WriteLine(myDelegate.Invoke(30, 40));


        }
    }
}
