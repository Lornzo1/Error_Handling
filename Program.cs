using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Error_Handling
{
    class Program
    {
        static double Sqrt()
        {
            Console.WriteLine("input the number");
            var t = Console.ReadLine();
            double a;
            try
            {
                a = Math.Sqrt(Convert.ToDouble(t));
            }
            catch (SystemException)
            {
                a =  Sqrt();
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sqrt());
        }
    }
}
