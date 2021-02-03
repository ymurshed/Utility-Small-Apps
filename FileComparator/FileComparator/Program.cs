using System;

namespace FileComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = FileHelper.ReadFile();
            Comparator.PerformComparison(dataSet.Item1, dataSet.Item2);
            Console.WriteLine("Items from Input file not found in Lookup file are saved into Output file!");
            Console.ReadLine();
        }
    }
}
