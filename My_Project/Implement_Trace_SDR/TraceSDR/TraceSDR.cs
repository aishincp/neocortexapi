using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceSDR
{
    /// <summary>
    /// Prints out all encoder values with their similarities by encoding of the Day and Time in the combined SDR.
    /// </summary>
    [TestMethod]
        public void WeekTimeEncodingTest()
        {
            var folderName = Directory.CreateDirectory(nameof(WeekTimeEncodingTest)).Name;

            ScalarEncoder timeEncoder = new ScalarEncoder(new Dictionary<string, object>()
            {
                { "W", 5},
                { "N", 30},
                { "MinVal", (double)0},
                { "MaxVal", (double)24},
                { "Periodic", false},
                { "Name", "Time of the day."},
                { "ClipInput", true},
            });

            Console.WriteLine("\nTime");
            Console.WriteLine(timeEncoder.TraceSimilarities());

            ScalarEncoder dayEncoder = new ScalarEncoder(new Dictionary<string, object>()
            {
                { "W", 3},
                { "N", 10},
                { "MinVal", (double)1},
                { "MaxVal", (double)8},
                { "Periodic", false},
                { "Name", "Day of the week."},
                { "ClipInput", true},
            });

            Console.WriteLine("\nDay of the Week");
            Console.WriteLine(dayEncoder.TraceSimilarities());

            string results = timeEncoder.TraceSimilarities();

            Dictionary<string, int[]> sdrDict = new Dictionary<string, int[]>();

            for (int day = 1; day < 8; day++)
            {
                for (int hour = 0; hour < 24; hour++)
                {
                    var sdrHour = timeEncoder.Encode(hour);
                    var sdrDay = dayEncoder.Encode(day);
                    List<int> sdrDayTime = new List<int>();

                    sdrDayTime.AddRange(sdrDay);
                    sdrDayTime.AddRange(sdrHour);

                    string key = $"{day.ToString("00")}-{hour.ToString("00")}";

                    sdrDict.Add(key, sdrDayTime.ToArray());

                    var str =Helpers.StringifyVector(sdrDayTime.ToArray());

                    //int[,] twoDimenArray = ArrayUtils.Make2DArray<int>(sdrDayTime.ToArray(), (int)Math.Sqrt(sdrDayTime.ToArray().Length), (int)Math.Sqrt(sdrDayTime.ToArray().Length));
                    //var twoDimArray = ArrayUtils.Transpose(twoDimenArray);
                    
                    //NeoCortexUtils.DrawBitmap(twoDimArray, 1024, 1024, Path.Combine(folderName, $"{key}.jpg"), Color.Black, Color.Gray, text: $"{day}-{hour}".ToString());
                }
            }

            Console.WriteLine("\nDay-Time");

            Console.WriteLine(Helpers.TraceSimilarities(sdrDict));
        
            PrintBitMap(timeEncoder, nameof(ScalarEncodingTest));

        }

    internal class ScalarEncoder
    {
        private Dictionary<string, object> dictionary;

        public ScalarEncoder(Dictionary<string, object> dictionary)
        {
            this.dictionary = dictionary;
        }
    }
}
