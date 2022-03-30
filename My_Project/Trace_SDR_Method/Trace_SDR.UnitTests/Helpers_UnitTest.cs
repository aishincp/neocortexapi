using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trace_SDR.UnitTests
{
    /// <summary>
    /// Compares the similarity of multiple SDRs.
    /// </summary>
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

<<<<<<< HEAD
            var expectedResult = new StringBuilder();
            
            var sdr1 = new StringBuilder();
            sdr1.Append("51, 76, 87,    , ");

            var sdr2 = new StringBuilder();
            sdr2.Append("51, 76,   , 113, ");

            expectedResult.AppendLine(sdr1.ToString());
            expectedResult.AppendLine(sdr2.ToString());

            Assert.IsTrue(output == expectedResult.ToString());
           
=======
            var expectedOutput = "51, 76, 87,    ,  \n51, 76,   , 113,";

            Assert.IsTrue(output == expectedOutput);
            Console.WriteLine($"{expectedOutput}");
>>>>>>> 4f27fdbaa65f1bf5bc36651ca08ec5930e8b859d

        }
    }
}
