using System.Collections.Generic;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void RegularList_PositiveElements()
        {
            List<int> list = new List<int>() {1, 2, 3, 4};
            int result;

            result = MyMath.Operations.Max(list);

            Assert.AreEqual(result, 4);
        }

        [Test]
        public void RegularList_NegativeElements()
        {
            List<int> list = new List<int>() {-1, -2, -3, -4};
            int result;

            result = MyMath.Operations.Max(list);

            Assert.AreEqual(result, -1);
        }

        [Test]
        public void EmptyList()
        {
            List<int> list = new List<int>() {};
            int result;

            result = MyMath.Operations.Max(list);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void MaxInTheMiddle()
        {
            List<int> list = new List<int>() {-3, -2, -1, -4, -5};
            int result;

            result = MyMath.Operations.Max(list);

            Assert.AreEqual(result, -1);
        }
    }
}