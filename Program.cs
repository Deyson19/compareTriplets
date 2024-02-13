// See https://aka.ms/new-console-template for more information
using compareTriplets;

Console.WriteLine("Hello, World!");

System.Console.WriteLine("Alice Values");
//List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

System.Console.WriteLine("Bob Values");

//List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

List<int> alice = [8, 5, 2];
List<int> bob = [6, 5, 4];
List<int> result = CompareProvider.compareTriplets(alice, bob);

foreach (var item in result)
{
    Console.WriteLine(item);
}