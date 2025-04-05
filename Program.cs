using System;

class Program
{
 static void Main()
    {
        int number;
        int max = int.MinValue;

        Console.WriteLine("Enter ur number. Enter 0 to end ur sequence of numbers.");

        do
        {
            number = int.Parse(Console.ReadLine());

            if (number != 0 && number > max)
            {
                max = number;
            }

        } while (number != 0);

        if (max == int.MinValue)
        {
            Console.WriteLine("You didnt enter any digit.");
        }
        else
        {
            Console.WriteLine("Your max number: " + max);
        }
    }
}