using System;
using System.Buffers;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void BasicTest()
        {
            Assert.Pass();
        }

        [Test]
        public void RegularDivision_MatrixZeros_ByOne()
        {
            int[,] matrix = new int[10,10];
            int[,] matrixZeros = new int[10,10];
            int num = 1;

            matrix = MyMath.Matrix.Divide(matrix, num);

            Assert.AreEqual(matrix, matrixZeros);
        }

        [Test]
        public void RegularDivision()
        {
            int[,] matrix = {{1, 2, 3}, {3, 2, 1}};
            int[,] matrixExpected = {{0, 1, 1}, {1, 1, 0}};
            int num = 2;

            matrix = MyMath.Matrix.Divide(matrix, num);

            Assert.AreEqual(matrix, matrixExpected);
        }

        [Test]
        public void DivisionByZero()
        {
            int[,] matrixZeros = new int[10,10];
            int[,] matrixResult;
            int num = 0;

            matrixResult = MyMath.Matrix.Divide(matrixZeros, num);

            Assert.IsNull(matrixResult);
        }

        [Test]
        public void NullMatrix()
        {
            int[,] matrixZeros = null;
            int[,] matrixResult;
            int num = 1;

            matrixResult = MyMath.Matrix.Divide(matrixZeros, num);

            Assert.IsNull(matrixResult);
        }
    }
}