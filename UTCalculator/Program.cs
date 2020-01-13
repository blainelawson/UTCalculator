using System;

namespace UTCalculator
{
    public class CalculatorFeatures
    {
        public static int AddTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatorFeatures.AddTwoNumbers(10,4));
            Console.ReadLine();
        }
    }
}
