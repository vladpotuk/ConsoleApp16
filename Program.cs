using System;

class Program
{
    static void Main()
    {
        
        int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

        Console.WriteLine("Масив:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        
        Console.WriteLine("Введіть три числа через пробіл:");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 3)
        {
            Console.WriteLine("Некоректне введення. Будь ласка, введіть три числа через пробіл.");
            return;
        }

        int num1, num2, num3;
        if (!int.TryParse(input[0], out num1) || !int.TryParse(input[1], out num2) || !int.TryParse(input[2], out num3))
        {
            Console.WriteLine("Некоректне введення. Будь ласка, введіть цілі числа.");
            return;
        }

        
        int count = 0;
        for (int i = 0; i <= array.Length - 3; i++)
        {
            if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
            {
                count++;
            }
        }

        Console.WriteLine($"Кількість повторень послідовності {num1} {num2} {num3} в масиві: {count}");

        Console.ReadLine(); 
    }
}
