using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class CatAndMouse
    {

        public string catAndMouse(int x, int y, int z)
        {
            int catADistance = Math.Abs(x - z);
            int catBDistance = Math.Abs(y - z);

            if(catADistance == catBDistance)
            {
                return "Mouse C";
            } else if(catADistance < catBDistance)
            {
                return "Cat A";
            } else
            {
                return "Cat B";
            }

        }

        [TestMethod]
        public void CatAndMouseMethod()
        {
            string output = catAndMouse(1, 2, 3);
            string output1 = catAndMouse(1, 3, 2);

            Assert.AreEqual("Cat B", output);
            Assert.AreEqual("Mouse C", output1);
        }
    }
}
