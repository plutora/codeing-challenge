// See https://aka.ms/new-console-template for more information

using Challenge1;

Console.WriteLine("complete the implementation of these methods");

var inputArray = new int[] {1,6,8,7,34,1,2323,44,56,5,346,76,1,436346,4,87,5,342,5,235,5,678,97,4345,23,1,4,1};

var response = IntFunctions.FindMinAndMax(inputArray);

Console.WriteLine($"Min found to be : {response.min}");
Console.WriteLine($"Max found to be : {response.max}");

var average = IntFunctions.FindTheAverage(inputArray);

Console.WriteLine($"Average found to be : {average}");

var mode = IntFunctions.FindTheMode(inputArray);

Console.WriteLine($"Mode found to be : {mode}");
