using System;
using System.Text;

public class Helpers
{
    public Helpers()
    {

    }

    public static StringBuilder[] StringifyVector(List<List<int>> vector)
    {
        var ptrs = new int[vector.Count];           //initializes as [0,0] for both sdr1 & sdr2 
        var output = new StringBuilder[vector.Count];

        while (true)
        {
            int index = 0;                          //to decide which sdr to take
            int minActiveColumn = -1; 

            foreach (var ptr in ptrs)               //pointer loops twice for 2 sdrs
            {                                       //on each loop you get the current index of that sdr
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
            index = 0;                                  //resetting the index value
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



}                                                           //END
