using System;
using System.Collections.Generic;

Console.WriteLine("\nHello Folks, Let's make a well-formatted multiple sdr values\n");

/// <summary>
/// We are implementing the Stringify method using two list of SDR values as string
/// </summary>
var list = new int[] { 51, 76, 87  };  // sdr1 values
var list1 = new int[] { 51, 76, 113 };  //sdr2 values

var output = Helpers.StringifyVector(new List<int[]> { list, list1 });

Console.WriteLine(output);


