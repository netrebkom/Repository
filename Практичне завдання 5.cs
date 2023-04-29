using System;
using System.Collections.Generic;

class Program
{
    enum AccountingSystem
    {
        Program1 = 1,
        Program2,
        Program3
    }

    enum LogisticsSystem
    {
        Program4 = 4,
        Program5,
        Program6
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
        Console.WriteLine("Перелік систем обліку:");
        Console.WriteLine($"{(int)AccountingSystem.Program1} - {AccountingSystem.Program1}");
        Console.WriteLine($"{(int)AccountingSystem.Program2} - {AccountingSystem.Program2}");
        Console.WriteLine($"{(int)AccountingSystem.Program3} - {AccountingSystem.Program3}");

        Console.WriteLine("\nПерелік систем логістики:");
        Console.WriteLine($"{(int)LogisticsSystem.Program4} - {LogisticsSystem.Program4}");
        Console.WriteLine($"{(int)LogisticsSystem.Program5} - {LogisticsSystem.Program5}");
        Console.WriteLine($"{(int)LogisticsSystem.Program6} - {LogisticsSystem.Program6}");

        Console.Write("\nВведіть номери продуктів, які бажаєте придбати, розділені комами: ");
        string input = Console.ReadLine();
        string[] productNumbers = input.Split(',');

        List<string> selectedAccountingSystems = new List<string>();
        List<string> selectedLogisticsSystems = new List<string>();

        foreach (string number in productNumbers)
        {
            int parsedNumber;
            if (int.TryParse(number, out parsedNumber))
            {
                if (Enum.IsDefined(typeof(AccountingSystem), parsedNumber))
                {
                    selectedAccountingSystems.Add($"{parsedNumber} - {Enum.GetName(typeof(AccountingSystem), parsedNumber)}");
                }
                else if (Enum.IsDefined(typeof(LogisticsSystem), parsedNumber))
                {
                    selectedLogisticsSystems.Add($"{parsedNumber} - {Enum.GetName(typeof(LogisticsSystem), parsedNumber)}");
                }
            }
        }

        Console.WriteLine("\nВи обрали наступні продукти:\n");
        if (selectedAccountingSystems.Count > 0)
        {
            Console.WriteLine("Системи обліку:");
            Console.WriteLine(string.Join("\n", selectedAccountingSystems));
            Console.WriteLine();
        }

        if (selectedLogisticsSystems.Count > 0)
        {
            Console.WriteLine("Системи логістики:");
            Console.WriteLine(string.Join("\n", selectedLogisticsSystems));
            Console.WriteLine();
        }

        Console.WriteLine("Автор: Марина");
        Console.ReadLine();
    }
}
