// IST 1551 Lab 1, Jordan Massey, 1/31/2024

string name;

Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");
name = Console.ReadLine() ?? "No one";

Console.WriteLine($"Noted: {name} got bread.");