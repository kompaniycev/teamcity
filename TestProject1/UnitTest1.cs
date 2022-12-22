using NUnit.Framework;
using teamcity;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        // [Ignore("This test is disabled")]
        public static void TestOne()
        {
            Assert.AreEqual(Program.Factorial(1), 1);
        }

        [Test]
        // [Ignore("This test is disabled")]
        public static void TestTwo()
        {
            Assert.AreEqual(Program.Factorial(6), 720);
        }

        [Test]
        // [Ignore("This test is disabled")]
        public static void TestThree()
        {
            Assert.AreEqual(Program.Factorial(7), 5040);
        }
    }
}