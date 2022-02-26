using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
var list = new List<int> { 51, 76, 87, 113, 116, 118, 122, 152, 156, 163, 179, 181, 183, 186, 188, 190, 195, 210, 214, 224 };  // created new list with sdr1 values
var list1 = new List<int> { 51, 76, 113, 116, 118, 156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243 };  //sdr2 values

var outputs = Helpers.StringifyVector(new List<List<int>> { list, list1 });  //calling the new StringifyVector method and can take multiple sdr values as input
foreach (var output in outputs)
{
    Console.WriteLine(output.ToString());
}

