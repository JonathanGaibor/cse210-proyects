using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (true)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
                break;

            numbers.Add(number);
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("The largest number is: " + max);

            // Desafío de estiramiento
            List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
            if (positiveNumbers.Count > 0)
            {
                int minPositive = positiveNumbers.Min();
                Console.WriteLine("The smallest positive number is: " + minPositive);
                Console.WriteLine("The sorted list is:");
                numbers.Sort();
                numbers.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
