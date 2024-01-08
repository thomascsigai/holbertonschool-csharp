using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddingTwoZeros_Returns0()
        {
            int result = MyMath.Operations.Add(0, 0);
            
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Adding1and2_Returns3()
        {
            int result = MyMath.Operations.Add(1, 2);

            Assert.AreEqual(result, 3);
        }
    }
}