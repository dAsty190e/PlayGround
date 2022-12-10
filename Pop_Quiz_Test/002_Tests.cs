using _002_PopQuiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pop_Quiz_Test
{
    [TestClass]
    public class _002_Tests
    {
        [TestMethod]
        public void TestGoTo()
        {
            var rider = new Rider();
            Assert.AreEqual(" goes to ", rider.GoTo());
            rider.Destination = "home";
            Assert.AreEqual(" goes to home", rider.GoTo());
            rider = new Rider("Joe");
            rider.Destination = "work";
            Assert.AreEqual("Joe goes to work", rider.GoTo());
        }
    }
}
