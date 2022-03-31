using System;
using System.Collections.Generic;

Console.WriteLine($"Hello Folks");
Console.WriteLine("\nLet's make a well-formatted multiple SDR values\n");

/// <summary>
/// Stores random SDR values from one dimensional matrix
/// </summary>
/// <param name="list">First set of SDR</param>
/// <param name="list1">Second set of SDR</param>
/// <returns></returns>

var list = new int[] { 051, 076, 087, 113, 116, 118, 122, 152, 156, 163, 179, 181, 183, 186, 188, 190, 195, 210, 214, 224,}; 
var list1 = new int[] { 051, 076, 113, 116, 118, 156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243 };  

/// <summary>
/// This method implements the well formatted pattern of SDR values from the HTM. 
/// </summary>
/// <param name="output"></param>
/// <returns></returns>

var output = Helpers.StringifyTraceSDR(new List<int[]> { list, list1 });
Console.WriteLine(output);
