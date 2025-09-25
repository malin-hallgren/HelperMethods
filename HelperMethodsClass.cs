using System;

public static class HelperMethodsInput
{
    //Prompts and takes user input for an integer, error manages these
    public static int UserInputInt(string prompt = "Please input a number:")
    {
        bool validInput = false;
        int result = 0;

        while (!validInput)
        {
            Console.WriteLine(prompt);
            validInput = int.TryParse(Console.ReadLine(), out result);
        }

        return result;
    }

    public static int UserInputInt(int minRange, int maxRange, string prompt = $"Please input a number:")
    {
        bool validInput = false;
        int result = 0;

        while (!validInput)
        {
            Console.WriteLine(prompt);
            validInput = int.TryParse(Console.ReadLine(), out result);

            if (!validInput || result < minRange || result >= maxRange)
            {
                validInput = false;
            }
        }

        return result;
    }

    public static string UserInputStringIsValid(string prompt, string errorPrompt)
    {
        string? userInput;
        bool validInput = false;

        Console.WriteLine(prompt);
        do
        {
            userInput = Console.ReadLine();


            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine(errorPrompt);
                continue;
            }
            else
            {
                validInput = true;
            }

        } while (!validInput);

        return userInput;
    }



    public static string UserInputStringRange(int minRange, int maxRange, string prompt = $"Please input a string:")
    {
        bool validInput = false;
        string output = "";

        while (!validInput)
        {
            Console.WriteLine(prompt);
            output = Console.ReadLine();

            if (output.Length >= minRange && output.Length < maxRange)
            {
                validInput = true;
            }
        }

        return output;
    }
}

public static class HelperMethodsFormat
{
    public static string[] SplitBySpace(string inputString)
    {
        inputString = inputString.Trim();
        string[] splitString = inputString.Split(' ');

        return splitString;
    }

    public static string DisplayNumberTruncated(float numberToTruncate, int amountFloatingPoints)
    {
        string output = numberToTruncate.ToString($"F{amountFloatingPoints}");
        return output;
    }

    public static string DisplayNumberTruncated(double numberToTruncate, int amountFloatingPoints)
    {
        string output = numberToTruncate.ToString($"F{amountFloatingPoints}");
        return output;
    }

    public static string DisplayNumberTruncated(decimal numberToTruncate, int amountFloatingPoints)
    {
        string output = numberToTruncate.ToString($"F{amountFloatingPoints}");
        return output;
    }

    public static void TypewriterEffect (string input, int delay = 50)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                Console.Write(input[i]);
                i++;
            }
            if (input[i] == '\n')
            {
                Thread.Sleep(delay * 10);
            }
            Console.Write(input[i]);
            Thread.Sleep(delay);
        }
        Console.WriteLine("\n(Press ENTER to continue)");
        Console.ReadLine();
    }
}

public static class HelperMethodsPropertySetter
{
    public static string SetterStringNotEmpty(string value, string currentValue, string message = "Faulty assignment, must not be null or empty.\nReverting to previous value, if previous is null, value will be \"ERROR\"")
    {
        if (!String.IsNullOrEmpty(value))
        {
            return value;
        }
        else
        {
            Console.WriteLine(message);
            if (!String.IsNullOrEmpty(currentValue))
            {
                Console.WriteLine($"Value set to previous: {currentValue}");
                return currentValue;
            }
            else
            {
                Console.WriteLine("Value set to: ERROR - Faulty Value");
                return "ERROR - Faulty Value";
            }
        }
    }

    public static double SetterDoublePositive(double value, double currentValue, string message = "Faulty assignment, must be above or equal to 0.\nReverting to previous value, if previous is invalid, value is set to 0")
    {
        if (value >= 0)
        {
            return value;
        }
        else
        {
            Console.WriteLine(message);
            if (currentValue >= 0)
            {
                Console.WriteLine($"Value set to previous value: {currentValue}");
                return currentValue;
            }
            else
            {
                Console.WriteLine("Value set to 0");
                return 0;
            }
        }
    }

    public static int SetterIntPositive(int value, int currentValue, string message = "Faulty assignment, must be above or equal to 0.\nReverting to previous value, if previous is invalid, value is set to 0")
    {
        if (value > 0)
        {
            return value;
        }
        else
        {
            Console.WriteLine(message);
            if (currentValue > 0)
            {
                Console.WriteLine($"Value set to previous value: {currentValue}");
                return currentValue;
            }
            else
            {
                Console.WriteLine("Value set to 0");
                return 0;
            }
        }
    }
}
