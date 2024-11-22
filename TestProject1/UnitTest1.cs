using FluentAssertions;
using FunctionalProgramming;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

            [TestCase(10, 100)]

            public void SquareItTest(int input, int expected)
            {
                int result = FunctionalProgramming.Exercises001.SquareIt(input);
                result.Should().Be(expected);
            }

        [Test]
        public void GetEmailList_ShouldReturnCorrectEmails()
        {
            List<string> emailList = Exercises002.GetCoolPeople();

            emailList.Should().BeEquivalentTo(new List<string>
            {
                "rich.neat@boardgamer.com",
                "poppy.mcdonnell@irishdancer.com",
                "neil.hughes@walkingoncustard.com",
                "alice.yang@midfielder.com",
                "pippa.austin@musician.com"
            });
        }
        [TestCase(new int[] { 1, 2, 3}, new int[] {1, 4, 9})]
        public void TestSquareNums(int[] input, int[] expected)
        {
            List<int> inputList = input.ToList();
            List<int> expectedList = expected.ToList();

            Exercises002.PrintSquaredNums(inputList);
            inputList.Should().BeEquivalentTo(expected);


        }
    }
}