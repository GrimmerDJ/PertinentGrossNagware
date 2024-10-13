using System;

class Program
{
    static void Main()
    {
        // Declare constants for valid temperature range
        const int MinTemperature = -30;
        const int MaxTemperature = 130;

        // Array to store temperatures
        int[] temperatures = new int[5];

        // Get 5 valid temperatures from user input
        for (int i = 0; i < temperatures.Length; i++)
        {
            int temp;
            bool isValid;

            do
            {
                Console.Write($"Enter temperature {i + 1} (between {MinTemperature} and {MaxTemperature}): ");
                temp = int.Parse(Console.ReadLine());

                isValid = temp >= MinTemperature && temp <= MaxTemperature;

                if (!isValid)
                {
                    Console.WriteLine($"Invalid temperature. Please enter a value between {MinTemperature} and {MaxTemperature}.");
                }
            } while (!isValid);

            temperatures[i] = temp;
        }

        // Determine the pattern of temperature changes
        bool gettingWarmer = true;
        bool gettingCooler = true;

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] <= temperatures[i - 1])
            {
                gettingWarmer = false;
            }

            if (temperatures[i] >= temperatures[i - 1])
            {
                gettingCooler = false;
            }
        }

        // Display the appropriate message
        if (gettingWarmer)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (gettingCooler)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It’s a mixed bag");
        }

        // Display the temperatures in the order they were entered
        Console.WriteLine("\nTemperatures entered:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        // Calculate and display the average of the temperatures
        double total = 0;
        foreach (int temp in temperatures)
        {
            total += temp;
        }

        double average = total / temperatures.Length;
        Console.WriteLine($"\nAverage temperature: {average:F2}");
    }
}
