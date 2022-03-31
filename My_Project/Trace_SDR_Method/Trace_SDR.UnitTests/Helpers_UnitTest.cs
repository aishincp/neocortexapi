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

            //First SDR vector
            var list = new int[] { 51, 76, 87 };
            //Second SDR vector
            var list1 = new int[] { 51, 76, 113 };
            //Stores the two SDRs
            var output = Helpers.StringifyTraceSDR(new List<int[]> { list, list1 });

            /// <summary>
            /// This result stores the SDR vectors same as output for the comparison. 
            /// </summary>
            /// <param name="expectedResult"></param>
            /// <returns></returns>
            var expectedResult = new StringBuilder();
            var sdr1 = new StringBuilder();
            sdr1.Append("51, 76, 87,    , ");

            var sdr2 = new StringBuilder();
            sdr2.Append("51, 76,   , 113, ");

            expectedResult.AppendLine(sdr1.ToString());
            expectedResult.AppendLine(sdr2.ToString());

            Console.WriteLine($"{output}");
            var expectedOutput = "51, 76, 87,    ,  \n51, 76,   , 113,";
            
            //Tests if both have same values 
            Assert.IsTrue(output == expectedResult.ToString());
           
            //Assert.IsTrue(output == expectedOutput);
            Console.WriteLine($"{expectedOutput}");


        }
    }
}
