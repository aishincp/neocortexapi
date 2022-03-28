using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trace_SDR.UnitTests
{
    [TestClass]
    public class Helpers_UnitTest
    {
        [TestMethod]
        public void StringifyTest()
        {

            var list = new int[] { 51, 76, 87 };

            var list1 = new int[] { 51, 76, 113 };

            var output = Helpers.StringifyVector(new List<int[]> { list, list1 });


            var expectedOutput = "51, 76, 87,    ,  \n51, 76,   , 113,";


            Assert.IsTrue(output == expectedOutput);
            Console.WriteLine($"{expectedOutput}");

        }
    }
}