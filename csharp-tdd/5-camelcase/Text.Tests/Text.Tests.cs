using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void MultipleWords()
        {
            string str = "thisIsATest";

            Assert.AreEqual(Text.Str.CamelCase(str), 4);
        }

        [Test]
        public void EmptyString()
        {
            string str = "";

            Assert.AreEqual(Text.Str.CamelCase(str), 0);
        }

        [Test]
        public void OneWord()
        {
            string str = "test";

            Assert.AreEqual(Text.Str.CamelCase(str), 1);
        }

        [Test]
        public void TwoWords()
        {
            string str = "testTwo";

            Assert.AreEqual(Text.Str.CamelCase(str), 2);
        }
    }
}