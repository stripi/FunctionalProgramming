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
        
    }
}
