using System;

namespace AdditionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            string input1 = Console.ReadLine();
            
            Console.Write("Введіть друге число: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                double sum = num1 + num2;
                Console.WriteLine($"Сума {num1} + {num2} = {sum}");
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректні числа.");
            }
        }
    }
}
