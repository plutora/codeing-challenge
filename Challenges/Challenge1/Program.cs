// See https://aka.ms/new-console-template for more information

using Challenge1;

Console.WriteLine("complete the implementation of the findMinMax method");

var inputArray = new int[] {1,6,8,7,34,235,5,678,97,4345,23,1,4};

var response = IntFunctions.FindMinAndMax(inputArray);

Console.WriteLine($"Min found to be : {response.min}");
Console.WriteLine($"Max found to be : {response.max}");