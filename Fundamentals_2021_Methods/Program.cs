using System;

namespace SignofIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //SignChecker(num);
            string result = SignChecker(num);
            Console.WriteLine(result);

            //SignChecker(int.Parse(Console.ReadLine()));
        }

        static string SignChecker(int number)
        {
            string sign = null;

            if (number>0)
            {
                sign = "positive";
            }

            else if (number<0)
            {
                sign = "negative";
            }

            else
            {
                sign = "zero";
            }
            return $"The number {number} is {sign}.";

            //static void SignChecker(int number)
            //string sign = null;

            //if (number > 0)
            //{
            //    sign = "positive";
            //}

            //else if (number < 0)
            //{
            //    sign = "negative";
            //}

            //else
            //{
            //    sign = "zero";
            //}
            //Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
