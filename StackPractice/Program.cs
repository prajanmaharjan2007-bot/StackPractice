
Stack<string> names = new Stack<string>();

names.Push("Aachu");
names.Push("Prajan");
names.Push("heli");

foreach(String name in names)
{
    Console.WriteLine(name);
}


Console.WriteLine($"\n{names.Pop()}");