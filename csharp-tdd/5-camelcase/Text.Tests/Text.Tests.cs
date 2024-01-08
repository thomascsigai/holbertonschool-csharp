using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SimpleString()
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
    }
}