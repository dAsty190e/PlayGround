using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pop_Quiz_Test
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void MathTest()
        {
            var sum = new ClassCalculator();
            Assert.AreEqual(2, sum.Sum(1, 1));
            
            var multyply = new ClassCalculator();
            Assert.AreEqual(4, multyply.Multyply(2, 2));

            var divide = new ClassCalculator();
            Assert.AreEqual(3, divide.Divide(7, 2));

            var divideDouble = new ClassCalculator();
            Assert.AreEqual(3.5, divideDouble.Divide(7.0, 2.0));

            var subtrac = new ClassCalculator();
            Assert.AreEqual(2, subtrac.Subtraction(4, 2));

        }
    }
}
