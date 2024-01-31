Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");

String name = Console.ReadLine() ?? string.Empty;

while(name.Equals(string.Empty))
{
    Console.WriteLine("Please input a name");
    name = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine($"Noted: {name} got bread.");
