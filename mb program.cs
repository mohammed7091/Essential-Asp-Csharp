// Exercise file for LinkedIn Learning Course .NET Programming with C# Tijjani 
Abdullahi
// Example file for .NET Data Types
// Declare some types with values
int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;
Console.WriteLinxe($"{a}, {b}, {tf}, {c}, {f}, {d}");
// TODO: implicit type conversion
Console.WriteLine($"{c + a}");
Console.WriteLine($"{(char)(c + a)}");
Console.WriteLine($"{f + a}");
Console.WriteLine($"{f + c}");