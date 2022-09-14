// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loops and Branches!");

int counter = 0;
while (counter < 5)
{
    Console.WriteLine($"The counter is {counter}");
    counter++;
}

for (int row = 1; row < 4; row++)
{
    for (char column = 'a'; column < 'd'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

var names = new List<string> { "Maria", "Ana", "Felipe" };
names.Add("Bill");
names.Remove("Ana");
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"I've added {names[1]} and {names[2]} to the list");