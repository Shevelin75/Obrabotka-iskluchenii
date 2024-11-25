using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            string input2 = Console.ReadLine();

            double num1, num2;

            // Проверяем, являются ли введённые значения числами
            bool isNum1Valid = double.TryParse(input1, out num1);
            bool isNum2Valid = double.TryParse(input2, out num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                Console.WriteLine("Ошибка ввода данных. Пожалуйста, введите корректные числа.");
                return;
            }

            try
            {
                double result = Divide(num1, num2);
                Console.WriteLine($"Результат деления: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла неожиданная ошибка: {ex.Message}");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
