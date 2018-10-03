using System;
using test3.lib;
namespace test3.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ISequence t =new EvenNumbers();
            Console.WriteLine("Event Numbers!");
            t.getsequence(10).ForEach(x=>Console.WriteLine(x));
            Console.WriteLine("Fibonacci Numbers!");
            t=new Fibonaccinumbers();
            t.getsequence(10).ForEach(x=>Console.WriteLine(x));
        }
    }
}
