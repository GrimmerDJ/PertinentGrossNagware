using System;

class Program
{
    static void Main()
    {
        const int MinTemperature = -30;
        const int MaxTemperature = 130;

        int[] temperatures = new int[5];

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

        Console.WriteLine("\nTemperatures entered:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        double total = 0;
        foreach (int temp in temperatures)
        {
            total += temp;
        }

        double average = total / temperatures.Length;
        Console.WriteLine($"\nAverage temperature: {average:F2}");
    }
}
