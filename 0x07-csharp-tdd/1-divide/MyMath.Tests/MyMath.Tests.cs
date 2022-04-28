using NUnit.Framework;
using MyMath;
namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckNull()
        {
            var test = new int[,] { { 2, 4 }, { 6, 8 } };
            var res = MyMath.Matrix.Divide(null, 2);
                Assert.AreEqual(res, null);
        }
        [Test]
        public void check_num()
        {
            var test = new int[,] { { 2, 4 }, { 6, 8 } };

            var res = Matrix.Divide(test, 0);
            Assert.AreEqual(res, null);
        }
        [Test]
        public void check_result()
        {
            var test = new int[,] { { 2, 4 }, { 6, 8 } };
            var eg = new int[,] { { 1, 2 }, { 3, 4 } };

            var res = Matrix.Divide(test, 2);
            Assert.AreEqual(res,eg );
        }

    }
}