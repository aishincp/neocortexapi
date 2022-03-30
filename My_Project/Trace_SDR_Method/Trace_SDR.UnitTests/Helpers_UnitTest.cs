using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trace_SDR.UnitTests
{
    [TestClass]
    public class Helpers_UnitTest
    {
        /// <summary>
        /// Compares the similarity of multiple SDRs.
        /// </summary>
        [TestMethod]
        public void StringifyTest()
        {

            var list = new int[] { 51, 76, 87 };

            var list1 = new int[] { 51, 76, 113 };

            var output = Helpers.StringifyTraceSDR(new List<int[]> { list, list1 });

            var expectedResult = new StringBuilder();
            
            var sdr1 = new StringBuilder();
            sdr1.Append("51, 76, 87,    , ");

            var sdr2 = new StringBuilder();
            sdr2.Append("51, 76,   , 113, ");

            expectedResult.AppendLine(sdr1.ToString());
            expectedResult.AppendLine(sdr2.ToString());

            Assert.IsTrue(output == expectedResult.ToString());
           

        }
    }
}