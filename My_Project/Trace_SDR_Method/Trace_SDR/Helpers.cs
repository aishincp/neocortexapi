using System;
using System.Text;

public class Helpers
{
    /// <summary>
    /// This method implements the well formatted pattern of SDR values from the HTM.  
    /// This effect is taking a sample of sdrs that can be generated from Spatial Pattern and everytime the columns can vary in every set.
    /// So show the difference where the values are changing, we implement this method
    /// </summary>
    

    //List of int array for sdrs
    public static string StringifyVector(List<int[]> sdrs)
    {
        var heads = new List<int>(new int[sdrs.Count]);
        var outputs = new StringBuilder[sdrs.Count];
        //The count for sdr starting from initial position [0,0]
       

        while (true)
        {
            
            int minActiveColumn = -1;

            //pointer loops twice for both the sdrs & on each loop you get the current index of that particular sdr

            minActiveColumn = SDR_Results(sdrs, heads, minActiveColumn); 


            // Exit the program
            if (minActiveColumn == -1)
            {
                var result = new StringBuilder();
                foreach (var output in outputs)
                {
                    result.AppendLine(output.ToString());
                }
                return result.ToString();
            }
            //Output has a certain value
            Append_ActiveColumn(sdrs, heads, outputs, minActiveColumn);
            //here the output changes
            //Now compare the new ouput and the expected value of the output
        }
    }

    /// <summary>
    /// 1st method
    /// </summary>
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
    /// 2nd method
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
