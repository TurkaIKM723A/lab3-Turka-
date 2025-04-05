using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of ur array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter digits for ur array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;

        for (int i = 0; i < size / 2; i++)
        {
            if (array[i] != array[size - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Array is a palindrome.");
        }
        else
        {
            Console.WriteLine("Array is not a palindrome.");
        }
    }
}