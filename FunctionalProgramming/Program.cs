namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coolPeople = new List<string>();
            coolPeople = Exercises002.GetCoolPeople();
            coolPeople.ForEach(x => Console.WriteLine(x));


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
