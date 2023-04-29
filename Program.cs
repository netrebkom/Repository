using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            Console.Write("Введіть слово: ");
            string input = Console.ReadLine();

            int firstIndex = -1, secondIndex = -1;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
                if (firstIndex >= 0 && secondIndex >= 0)
                {
                    break;
                }
            }

            if (firstIndex >= 0 && secondIndex >= 0)
            {
                Console.WriteLine($"Знайдені дві однакові літери '{input[firstIndex]}' на позиції {firstIndex} та {secondIndex}."); 
            }
            else
            {
                Console.WriteLine("У слові відсутні дві однакові літери.");

            }
           
            Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити або натисніть '/' для виходу...");
            if (input == "/")
            {
                break;
            }
        
        }
    }
}