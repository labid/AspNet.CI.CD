using NUnit.Framework;

namespace TestUnitaire.CI.CD.github
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void Test1()
        { 
            Assert.Pass();
        }
    }
}