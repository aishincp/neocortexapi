using System;
using System.Text;

public class Helpers
{
    public Helpers()
    {

    }
    /// <summary>
    /// Implements the well formatted pattern of SDR values from the SP.  
    /// This effect is taking a sample of sdrs that can be generated from Spatial Pattern and everytime the columns can vary in every set.
    /// So show the difference where the values are changing, we implement this method
    /// </summary>
    public static StringBuilder[] StringifyVector(List<List<int>> vector)
    {
        //The count for sdr starting from initial position [0,0]
        var ptrs = new int[vector.Count];  
        var output = new StringBuilder[vector.Count];

        while (true)
        {
            /// <summary>
            /// <param name="output">The output SDRs of the Spatial Pooler compute cycle.</param>
            /// <returns></returns>
            /// 

            //The index will decide which SDR to take
            int index = 0;       
            int minActiveColumn = -1;

            //pointer loops twice for 2 sdrs
            //on each loop you get the current index of that sdr
                foreach (var ptr in ptrs)
            {
                var sdr = vector[index];  
                if (ptr > sdr.Count - 1)
                {
                    index++;
                    continue;
                }
                var activeColumn = sdr[ptr];
                if (minActiveColumn == -1)
                {
                    minActiveColumn = activeColumn;
                }
                else
                {
                    if (activeColumn < minActiveColumn)
                        minActiveColumn = activeColumn;
                }

                index++;
            }
            if (minActiveColumn == -1)
            {
                return output;
            }

            //resetting the index value again

            index = 0; 
            foreach (var ptr in ptrs)
            {
                if (output[index] == null)
                {
                    output[index] = new StringBuilder();
                }

                if (ptr < vector[index].Count && vector[index][ptr] == minActiveColumn)
                {
                    output[index].Append(minActiveColumn);
                    output[index].Append(", ");
                    ptrs[index]++;

                }
                else
                {
                    output[index].Append("  ");
                    output[index].Append(", ");
                }

                index++;
            }
        }
    }



}
