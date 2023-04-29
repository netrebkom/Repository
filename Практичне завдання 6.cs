using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
      
        string[] lines = File.ReadAllLines("input.txt");
     
        string[] sortedLines = lines.OrderBy(line => line).ToArray();
      
        File.WriteAllLines("output.txt", sortedLines);
    }
}
