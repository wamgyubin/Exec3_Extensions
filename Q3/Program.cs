using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入文字");
            string value2 = Console.ReadLine();

            string value1 = value2.ToInt(0);

            Console.WriteLine(value1);
        }
    }
    public static class SrtingExtensions
    {
        public static string ToInt(this string value, int defaultValue)
        {
            if (value == null) return value;
            if (string.IsNullOrEmpty(value)) return value;
            try
            {
                int number = Convert.ToInt32(value);

                return defaultValue == number ? value : number.ToString();
            }
            catch (Exception ex)
            {
                return $"{value}+無法轉換成數字";
            }
        }
    }
}
