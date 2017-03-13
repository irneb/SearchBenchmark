using System;
using BenchmarkDotNet.Running;

namespace SearchBenchmark
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Testing Searches through collections!");

            var summary = BenchmarkRunner.Run<CollectionTests>();
            Console.WriteLine(summary);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}