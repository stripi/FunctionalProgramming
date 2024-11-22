using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string> { "rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com", "neil.hughes@walkingoncustard.com", "alice.yang@midfielder.com", "pippa.austin@musician.com" };

        public static Action GetUsernames = () =>
                                                    {
                                                        List<string> emails = GetCoolPeople();
                                                        Console.WriteLine(emails[0]);
                                                        emails.ForEach(email => Console.WriteLine(email.Substring(0, email.IndexOf('@'))));
                                                        //emails.ForEach(email => Console.WriteLine(email));

                                                    };
        public static Action<List<string>> PrintCoolPeople = (names) => { names.ForEach(name => Console.WriteLine(name)); };

        public static Action<List<int>> SquaredNums = (numbers) => {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] * numbers[i];

            }

        };
      
        public static Action<List<int>> PrintNums = (numbers) => { numbers.ForEach(number => Console.WriteLine(number)); };

        public static Action<List<int>> PrintSquaredNums = (numbers) =>
                                                                        {
                                                                            SquaredNums(numbers);
                                                                            
                                                                            PrintNums(numbers);
                                                                        };

        public static Dictionary<string, List<string>> FilterEmail(List<string> emailList)
        {
            Dictionary<string, List<string>> filteredEmail = new Dictionary<string, List<string>>();
            List<string> couk = new List<string>();
            List<string> com = new List<string>();
            List<string> invalid = new List<string>();


            foreach (string email in emailList)
            {
                if (email.Contains(".co.uk"))
                    {
                    couk.Add(email); 
                    }
                else if (email.Contains(".com"))
                {
                    com.Add(email);
                }
                else
                {
                    invalid.Add(email);
                }
            }
            filteredEmail.Add(".co.uk", couk);
            filteredEmail.Add(".com", com);
            filteredEmail.Add("invalid", invalid);


            return filteredEmail;
        }


    }
}
