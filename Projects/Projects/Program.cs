double input = double.Parse(Console.ReadLine());
if (input > 30)
{
    Console.WriteLine("too hot");
}
else if (input >= 26)
{
    Console.WriteLine("hot");
}
else if (input >= 21)
{ 
    Console.WriteLine("warm");
}
else if (input >= 16)
{
    Console.WriteLine("mild");
}
else if (input >= 11)
{
    Console.WriteLine("cool");
}
else if (input >= 5)
{
    Console.WriteLine("cold");
}
else 
{
    Console.WriteLine("freezing");
}