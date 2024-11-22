using FluentAssertions;

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
        
    }
}