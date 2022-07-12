int fieldArea = int.Parse(Console.ReadLine());
double wheatPerMeter = double.Parse(Console.ReadLine());
double neededFlour = double.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());
double totalWheat = (fieldArea * wheatPerMeter) * 0.4;
double flour = totalWheat / 2.5;
if (flour >= neededFlour)
{
    double remainingflour = flour - neededFlour;
    Console.WriteLine($"Good harvest this year! Total flour: {Math.Floor(flour)} kilos!");
    Console.WriteLine($"{Math.Ceiling(remainingflour)} kilos left -> {Math.Ceiling(remainingflour / workers)} kilos per person!");
}
else
{
    double shortage = Math.Floor(neededFlour - flour);
    Console.WriteLine($"It will be a tough winter! More {shortage} kilos flour needed");
}
