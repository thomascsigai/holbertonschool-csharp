using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SimpleString()
        {
            string str = "aacaa";

            Assert.AreEqual(Text.Str.UniqueChar(str), 2);
        }
        
        [Test]
        public void NonRepeatingChar()
        {
            string str = "aaccaa";

            Assert.AreEqual(Text.Str.UniqueChar(str), -1);
        }
    }
}