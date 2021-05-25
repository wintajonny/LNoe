using System;
int int1;
bool bool1;
int int2;
bool bool2;
do
{
    Console.WriteLine("Please enter a value (number)!");
    string value1 = Console.ReadLine();
    bool1 = Int32.TryParse(value1, out int1);
} while (bool1 == false);

do
{
    Console.WriteLine("Please enter the value (number) you want to be added!");
    string value2 = Console.ReadLine();
    bool2 = Int32.TryParse(value2, out int2);
} while (bool2 == false);
int sum = int1 + int2;
Console.WriteLine($"The sum of {int1} and {int2} is: {sum}");
