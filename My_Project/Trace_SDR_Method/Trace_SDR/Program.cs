using System;
using System.Collections.Generic;

Console.WriteLine($"Hello Folks");
Console.WriteLine("\nLet's make a well-formatted multiple SDR values\n");

/// <summary>
/// Stores random SDR values from one dimensional matrix
/// </summary>
/// <param name="list1">First set of SDR</param>
/// <param name="list2">Second set of SDR</param>
/// <returns></returns>

var list = new int[] { 51, 76, 87, };

var list1 = new int[] { 51, 76, 113, };

/// <summary>
/// This method implements the well formatted pattern of SDR values from the HTM. 
/// </summary>
/// <param name="output"></param>
/// <returns></returns>
var output = Helpers.StringifyTraceSDR(new List<int[]> { list, list1 });

Console.WriteLine(output);


//var expectedOutput = "51, 76, 87,    ,  \n51, 76,   , 113,";
//Console.WriteLine($"{expectedOutput}");