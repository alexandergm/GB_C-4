using System;

public class Program
{
    public static int[] FindSum(int[] array, int target)
    {
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            int left = i + 1;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[i] + array[left] + array[right];
                if (currentSum == target)
                {
                    return new int[] { array[i], array[left], array[right] };
                }
                else if (currentSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return new int[0];
    }

    public static void Main()
    {
        Console.Write("Введите количество элементов массива");
        int arrayCount = int.Parse(Console.ReadLine());

        int[] array = new int[arrayCount];

        for( int i = 0; i < array.Length; i++ )
        {
            Console.Write($"Введите элемент массива под индексом {i}:\t ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введите число: ");
        int target = int.Parse(Console.ReadLine());
        int[] result = FindSum(array, target);
        if (result.Length > 0)
        {
            Console.WriteLine(String.Join(", ", result));
        }
        else
        {
            Console.WriteLine("Таких чисел не существует");
        }
    }
}
