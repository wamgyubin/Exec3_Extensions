using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result1 = 33.IsEven();
            Console.WriteLine(result1);
            bool result2 = 33.IsOdd();
            Console.WriteLine(result2);
        }
    }
    public static class Math
    {
        public static bool IsEven(this int source)
        {
            return source % 2 == 0;
        }
        public static bool IsOdd(this int source)
        {
            return source % 2 == 1;
        }
    }
}
