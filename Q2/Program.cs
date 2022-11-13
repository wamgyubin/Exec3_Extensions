using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "0123456789";
            string result = value.Left(4);
            Console.WriteLine(result);
        }
    }
    public static class Math
    {
        public static string Left(this string Value, int length)
        {
            if (string.IsNullOrEmpty(Value))
                return string.Empty;
            if (length <= 0)
                return string.Empty;
            if (Value.Length < length)
                return Value;
            return Value.Substring(0, length);
        }
    }
}
