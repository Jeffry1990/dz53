using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = 0;
            int[] array = new int[lengthArray];
            int[] arrayCopy = new int[lengthArray];
            int arraySum = 0;
            string message;
            int enteredNumber;

            Console.WriteLine($"\nВведите любое число,программа его запомнит.\n\n" +
                $"Введите sum для выведения суммы всех чисел.\n\nВведите exit для выхода из программы.\n");

            while (true)
            {
                message = Console.ReadLine();

                if (message != "sum" && message != "exit")
                {
                    enteredNumber = Convert.ToInt32(message);
                    lengthArray += 1;
                    array = new int[lengthArray];

                    for (int i = 0; i < arrayCopy.Length; i++)
                    {
                        array[i] = arrayCopy[i];
                    }

                    array[lengthArray - 1] = enteredNumber;
                    arrayCopy = new int[lengthArray];

                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayCopy[i] = array[i];
                    }

                    arrayCopy[lengthArray - 1] = enteredNumber;
                }

                else if (message == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Clear();
                        arraySum += array[i];
                        Console.WriteLine($"Сумма чисел равна {arraySum}");
                    }
                }
                else if (message == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
            }
        }
    }
}
