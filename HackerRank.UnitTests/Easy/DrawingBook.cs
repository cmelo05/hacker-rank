using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class DrawingBook
    {
         /*
         * Complete the pageCount function below.
         */
        public int pageCount(int n, int p)
        {
            if(n == p)
            {
                return 0;
            }

            int fromStart = p - 1;
            int fromFinish = n - p;

            if(fromStart < fromFinish)
            {
                return p / 2;
            } else
            {
                if((n % 2 == 0) && (fromFinish == 1))
                {
                    return fromFinish;
                }

                return fromFinish / 2;
            }
        }


        [TestMethod]
        public void DrawingBookMethod()
        {
            int pages = pageCount(6, 2);
            int pages1 = pageCount(5, 4);
            int pages2 = pageCount(6, 4);
            int pages3 = pageCount(6, 5);

            Assert.AreEqual(1, pages);
            Assert.AreEqual(0, pages1);
            Assert.AreEqual(1, pages2);
            Assert.AreEqual(1, pages3);

        }
    }


}
