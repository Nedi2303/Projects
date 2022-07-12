string season = Console.ReadLine();
string groupType = Console.ReadLine();
int children = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
double price = 0;
string activities = "";
switch (season)
{
    case "winter":
        switch (groupType)
        {
            case "boys":
                price = 9.60;
                activities = "Box";
                break;

            case "girls":
                price = 9.60;
                activities = "Gymnastics";
                break;

            case "mixed":
                price = 10;
                activities = "Snowboard";
                break;
        }
        break;
    case "spring":        
        switch (groupType)
        {
            case "boys":
                price = 7.20;
                activities = "Tennis";
                break;

            case "girls":
                price = 7.20;
                activities = "Aerobics";
                break;

            case "mixed":
                price = 9.50;
                activities = "Cycling";
                break;
        }
        break;
    case "summer":
        switch (groupType)
        {
            case "boys":
                price = 15;
                activities = "Football";
                break;

            case "girls":
                price = 15;
                activities = "Volleyball";
                break;

            case "mixed":
                price = 20;
                activities = "Swimming";
                break;
        }
        break;       
}
double totalPrice = days * children * price;
if (children >= 50)
{
    totalPrice *= 0.5;
}
else if (children >= 20)
{
    totalPrice *= 0.85;
}
else if (children >= 10)
{
    totalPrice *= 0.95;
}
Console.WriteLine($"{activities} {totalPrice} BGN");

