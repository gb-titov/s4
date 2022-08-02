using System;
using System.ComponentModel;

namespace ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

            var data = GetUserInput();

            var powered = GetPower(data.number, data.power);

            Console.WriteLine($"{data.number},{data.power} -> {powered}");

        }


        static (int number, int power) GetUserInput()
        {

            while (true)
            {
                Console.Write("Введите число для возведения в степень: ");
                string n = Console.ReadLine();
                Console.Write("Введите степень: ");
                string pow = Console.ReadLine();
                if (!string.IsNullOrEmpty(n) && !string.IsNullOrEmpty(pow) && int.TryParse(n, out int num) && int.TryParse(pow, out int powNum) && powNum > 0)
                {
                    return (num, powNum);
                }

                Console.WriteLine("Неверный ввод!");
            }
            
        }

        static int GetPower(int number, int power)
        {
            int i = 2;
            int poweredNumber = number;
            while (i <= power)
            {
                poweredNumber *= number;
                i++;
            }

            return poweredNumber;
        }
    }
}
