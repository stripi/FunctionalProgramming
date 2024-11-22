using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
   public class Exercises001
    {
        public static Func<int, int> AddOne = num => num + 1;

        public static Func<int, int> SquareIt = num => num * num;

        public static Action<int> AddTen = num => Console.WriteLine(num + 10);

        public static Predicate<string> GrammarCheck = word => (word.StartsWith('A') && word.EndsWith('!'));

        public static Func<string, string, int> SumIndices = (word1, word2) => word1.IndexOf('a') + word2.IndexOf('e');

        public static Predicate<string> CheckDomain = email => email.Contains("@northcoders.co.uk");

        public static Predicate<string> CheckUsername = email => { bool trueeee = email.Substring(0, email.IndexOf('@')).Length >= 5; return trueeee; };


        public static string CheckValidEmail(string email)
        {
            if (CheckDomain(email) && CheckUsername(email)) return "Email domain and user valid, please continue";
            return "Email domain and user name invalid, please check your input";
        }
    }
}
