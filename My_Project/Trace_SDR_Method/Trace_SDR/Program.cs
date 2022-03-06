using System;
using System.Collections.Generic;

Console.WriteLine("\nHello Folks, Let's make a well-formatted multiple sdr values\n");

/// <summary>
/// We are implementing the Stringify method using two list of SDR as values sdr1 and sdr2 as string
/// </summary>
var list = new int[] { 051, 076, 087, 113, 116, 118, 122, 152, 156, 163, 179, 181, 183, 186, 188, 190, 195, 210, 214, 224,}; 
var list1 = new int[] { 051, 076, 113, 116, 118, 156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243 };  

var output = Helpers.StringifyVector(new List<int[]> { list, list1 });

Console.WriteLine(output);


