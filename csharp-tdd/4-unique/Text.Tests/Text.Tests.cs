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

        [Test]
        public void FirstCharIsUnique()
        {
            string str = "accbb";

            Assert.AreEqual(Text.Str.UniqueChar(str), 0);
        }

        [Test]
        public void LastCharIsUnique()
        {
            string str = "ccbba";

            Assert.AreEqual(Text.Str.UniqueChar(str), 4);
        }

        [Test]
        public void EmptyString()
        {
            string str = "";

            Assert.AreEqual(Text.Str.UniqueChar(str), -1);
        }
    }
}