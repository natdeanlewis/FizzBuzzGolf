using System;
using System.Linq;

namespace FizzBuzzGolf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Enumerable.Range(1, 100)
                .Select(i =>
                    (i % 3 == 0) | (i % 5 == 0) | (i % 7 == 0)
                        ? string.Concat(i % 3 == 0 ? "Fizz" : "", i % 5 == 0 ? "Buzz" : "", i % 7 == 0 ? "Bang" : "")
                        : i.ToString()).ToList().ForEach(Console.WriteLine);
        }
    }
}