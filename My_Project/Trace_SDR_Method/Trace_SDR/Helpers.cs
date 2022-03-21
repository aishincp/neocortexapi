using System;
using System.Text;

public class Helpers
{
    public Helpers()
    {

    }
    /// <summary>
    /// This method implements the well formatted pattern of SDR values from the SP.  
    /// This effect is taking a sample of sdrs that can be generated from Spatial Pattern and everytime the columns can vary in every set.
    /// So show the difference where the values are changing, we implement this method
    /// </summary>
    

    //List of int array for sdrs
    public static string StringifyVector(List<int[]> sdrs)
    {
            
        //The count for sdr starting from initial position [0,0]
        var heads =new List<int>(new int[sdrs.Count]);
        var outputs = new StringBuilder[sdrs.Count];

        while (true)
        {
            
      
            int minActiveColumn = -1;

            //pointer loops twice for 2 sdrs
            //on each loop you get the current index of that sdr
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
                        minActiveColumn = activeColumn;
                }
            }
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

        
    }



}
