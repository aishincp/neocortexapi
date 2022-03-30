using System;
using System.Text;

public class Helpers
{ 
    public Helpers()
    {

    }
    /// <summary>
    /// Creates string representation from one dimensional value. 
    /// </summary>
    /// <param name="sdrs">Stores the SDR sets.</param>
    /// <returns></returns>
    public static string StringifyTraceSDR(List<int[]> sdrs)
    {
        //List of string of arrays for SDR set
        var heads = new List<int>(new int[sdrs.Count]);

        //The count for SDR starting from initial position [0,0]
        var outputs = new StringBuilder[sdrs.Count];

        while (true)
        {
            //We set the minimum value as initial value of SDRs can be 0
            int minActiveColumn = -1;
            minActiveColumn = SDR_Results(sdrs, heads, minActiveColumn); 

            if (minActiveColumn == -1)
            {
                //Stores a mutable string of characters.
                var result = new StringBuilder();

                foreach (var output in outputs)
                {
                    result.AppendLine(output.ToString());
                }
                return result.ToString();
            }
            
            Append_ActiveColumn(sdrs, heads, outputs, minActiveColumn);
           
        }
    }

    /// <summary>
    /// Stores the SDR values from both sets and arrange them.
    /// </summary>
    /// <param name="sdrs">The SDR values as index bit of active neurons</param>
    /// <param name="heads">The two representations taken as input.</param>
    /// <param name="outputs">Represents every index bit of representations.</param>
    /// <param name="minActiveColumn">Stores the similar semantic active and inactive bits for comparison.</param>
    /// <summary>
    public static void Append_ActiveColumn(List<int[]> sdrs, List<int> heads, StringBuilder[] outputs, int minActiveColumn)
    {
        for (int i = 0; i < sdrs.Count; i++)
        {
            if (outputs[i] == null)
            {
                outputs[i] = new StringBuilder();
            }
            var head = heads[i];
            var sdr = sdrs[i];

            if (head < sdr.Length && sdr[head] == minActiveColumn)
            {
                outputs[i].Append(minActiveColumn);
                outputs[i].Append(", ");
                heads[i] = head + 1;
            }
            else
            {
                //Creates a padding or spacing on the indices of inactive bits
                var numOfSpaces = minActiveColumn.ToString().Length;    
                for (var j = 0; j < numOfSpaces; j++)
                {
                    outputs[i].Append(" ");
                }
                outputs[i].Append(", ");
            }
        }
    }

    /// <summary>
    /// Creates the reusults of SDRs in a well arrangement
    /// </summary>
    public static int SDR_Results(List<int[]> sdrs, List<int> heads, int minActiveColumn)
    {
        for (int i = 0; i < sdrs.Count; i++)
        {
            var head = heads[i];
            var sdr = sdrs[i];

            if (heads[i] > sdr.Length - 1)
            {
                continue;
            }

            var activeColumn = sdr[head];
            if (minActiveColumn == -1)
            {
                minActiveColumn = activeColumn;
            }
            else
            {
                if (activeColumn < minActiveColumn)
                {
                    minActiveColumn = activeColumn;
                }
            }
        }
        return minActiveColumn;
        
    }


   


}
