using NUnit.Framework;
using FizzBuzzTest;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class Test
        {
            [Test]
            public void Fizz()
            {
                Assert.That(Game.FinalOutput(3), Is.SameAs("Fizz"));
                Assert.That(Game.FinalOutput(6), Is.SameAs("Fizz"));
                Assert.That(Game.FinalOutput(9), Is.SameAs("Fizz"));
            }

            [Test]
            public void Buzz()
            {
                Assert.That(Game.FinalOutput(5), Is.SameAs("Buzz"));
                Assert.That(Game.FinalOutput(10), Is.SameAs("Buzz"));
                Assert.That(Game.FinalOutput(20), Is.SameAs("Buzz"));
            }

            [Test]
            public void FizzBuzz()
            {
                Assert.That(Game.FinalOutput(15), Is.SameAs("FizzBuzz"));
                Assert.That(Game.FinalOutput(30), Is.SameAs("FizzBuzz"));
                Assert.That(Game.FinalOutput(45), Is.SameAs("FizzBuzz"));
            }
        }
    }
}