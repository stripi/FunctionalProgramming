using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Exercises001
    {
        public static Func<int, int> AddOne = num => num + 1;

        public static Func<int, int> SquareIt = num => num * num;

        public static Action<int> AddTen = num => Console.WriteLine(num + 10);

        public static Predicate<string> GrammarCheck = word => (word.StartsWith('A') && word.EndsWith('!'));

        public static Func<string, string, int> SumIndices = (word1, word2) => word1.IndexOf('a') + word2.IndexOf('e');


    }
}
