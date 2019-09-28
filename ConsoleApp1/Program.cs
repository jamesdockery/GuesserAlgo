using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elimination e = new Elimination();
            Console.WriteLine("Elimination: ");
            Console.WriteLine(   e.Run(7));


            Console.WriteLine();



            Brute b = new Brute();
            Console.WriteLine("Brute: ");
            Console.WriteLine(b.Run(7));





            Console.WriteLine();


            RAlgo r = new RAlgo();

            Console.WriteLine("Random: ");
            Console.WriteLine(r.Run(7));


        }

    }
}
