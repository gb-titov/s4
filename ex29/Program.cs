using System;

namespace ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
            
            while (true)
            {
                Console.Write("Введите несколько чисел через запятую: ");
                string n = Console.ReadLine();

                int[] arr = GetArray(n);
                if (arr != null)
                {
                    Console.WriteLine($"{n} -> [{string.Join(",", Array.ConvertAll<int, string>(arr, Convert.ToString))}] ");
                    break;
                }
                Console.WriteLine("Неверный ввод!");
            }
        }



        static int[] GetArray(string str)
        {
            if (string.IsNullOrEmpty(str) || !str.Contains(','))
            {
                return null;
            }
            
            var arr = str.Split(",");

            var intArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (!int.TryParse(arr[i], out int r))
                {
                    return null;
                }

                intArr[i] = r;
            }

            return intArr;
        }
    }
}
