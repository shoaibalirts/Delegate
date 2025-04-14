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
            myDelegate = s.Add; // new MyDelegateType is redundant
            myDelegate += s.Multiply;
            // invoke method using delegate object
            myDelegate.Invoke(10, 20);



        }
    }
}
