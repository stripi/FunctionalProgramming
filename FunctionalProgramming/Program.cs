namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListManager listTest = new ListManager(new List<string> { "callum", "callym222323232", "callum3"});
            Predicate<string> filterTest = name => (name.Length > 6);
            List<string> output = listTest.Filter(filterTest);

            foreach (string outputItem in output)
            {
                Console.WriteLine(outputItem);
            }


            //Predicate<string> GrammarCheck = word => (word.StartsWith('A') && word.EndsWith('!'));




//            List<string> emailList = new List<string>
//{
//                "alice.yang@northcoders.com",
//                "richard.neat@northcoders.com",
//                "mario@plumbing.it",
//                "link@hyrule.co.uk",
//                "shrek@duloc.com",
//                "neil.hughes@walkingoncustard.com",
//                "csharp@microsoft.cs",
//                "ziggy@spidersfrommars.co.uk",
//                "lemmy@motorhead.co,uk",
//                "me@myhouse.sleep"
//};
//            var filteredEmails = Exercises002.FilterEmail(emailList);

//            foreach (var item in filteredEmails)
//            {
//                Console.WriteLine(item.Key);
//                item.Value.ForEach(Console.WriteLine);
//            }

            //List<string> coolPeople = new List<string>();
            //coolPeople = Exercises002.GetCoolPeople();
            //coolPeople.ForEach(x => Console.WriteLine(x));

            //Exercises002.GetUsernames();

            //  List<string> names = new List<string>() { "rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com", "neil.hughes@walkingoncustard.com", "alice.yang@midfielder.com", "pippa.austin@musician.com" };
            //List<String> names = Exercises002.GetCoolPeople();
            //Exercises002.PrintCoolPeople(names);
            //List<int> numbers = new List<int>() { 1, 2, 3 };
            //Exercises002.PrintSquaredNums(numbers);


            //int square = Exercises001.SquareIt(2);
            //Console.WriteLine($"SquareIt: {square}");
            //List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            //numbers.ForEach(Exercises001.AddTen);

            //List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            //Predicate<string> checkWord = Exercises001.GrammarCheck;
            //words.ForEach(word => Console.WriteLine(checkWord(word)));

            //Console.WriteLine(" Using directly inside");

            //words.ForEach(word => Console.WriteLine(Exercises001.GrammarCheck(word)));

            //string word1 = "start";
            //string word2 = "pale";

            //Console.WriteLine("Index of \'a\' in \"start\" + Index of \'e\' in \"pale\" " + Exercises001.SumIndices(word1,word2));

            //Console.WriteLine(Exercises001.CheckValidEmail("g@northcoders.co.uk")); 

        }
    }
}
