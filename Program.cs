// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

RomanNumeral.RomanNum rn = new();
string Roman = "CMXLVIII";

int total = rn.RomanToInt(Roman); 
System.Console.WriteLine($"The converted value of {Roman} is {total}.");