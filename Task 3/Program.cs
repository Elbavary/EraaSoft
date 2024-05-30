using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Write a C# program that reads a list of integers from the user and throws an exception if any numbers are duplicates.
        try
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter integers separated by spaces:");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            HashSet<int> uniqueNumbers = new HashSet<int>();
            foreach (string token in tokens)
            {
                int number = int.Parse(token);
                if (!uniqueNumbers.Add(number))
                {
                    throw new ArgumentException("Duplicate number found: " + number);
                }
                numbers.Add(number);
            }

            Console.WriteLine("All numbers are unique.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


        // 2. Write a C# program to create a method that takes a string as input and throws an exception if the string does not contain vowels.
        try
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            CheckForVowels(input);
            Console.WriteLine("The string contains vowels.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void CheckForVowels(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input string cannot be null or empty.");
        }

        List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                return;
            }
        }

        throw new ArgumentException("The string does not contain any vowels.");
    }
}