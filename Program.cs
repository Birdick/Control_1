Console.Clear();
string[] GetArray;
Console.WriteLine("Enter any digits:");
string row = Console.ReadLine()!;
GetArray = row.Split(' ');
var Sum = new string[GetArray.Length];
var IntSum = 0;
foreach (var value in GetArray)
{
    if (value.Length <= 3)
    {
        Sum[IntSum] = value;
        IntSum++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, Sum, 0, IntSum));
Console.WriteLine();
