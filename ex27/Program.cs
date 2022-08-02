using System;
using System.Threading.Channels;

namespace ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            var data = GetUserInput();

            var sum = GetDigitSum(data);

            Console.WriteLine($"{data} -> {sum}");

        }

        static int GetDigitSum(int number)
        {
            int result = 0;

            while (number >= 1)
            {
                result += number % 10;
                number /= 10;
            }

            return result;
        }


        static int GetUserInput()
        {

            while (true)
            {
                Console.Write("Введите число для подсчета суммы цифр: ");
                string n = Console.ReadLine();
                if (!string.IsNullOrEmpty(n) && int.TryParse(n, out int num))
                {
                    return num;
                }

                Console.WriteLine("Неверный ввод!");
            }
            
        }
    }
}
