//int count = int.Parse(Console.ReadLine());
//int max = 0;
//int min = 0;
//for (int i = 0; i < count; i++)
//{
//    int number = int.Parse(Console.ReadLine());
//    if (number > max)
//    {
//        max = number;
//    }
//    if (number < min)
//    {
//        min = number;
//    }
//}
//Console.WriteLine($"Max: {max}");
//Console.WriteLine($"Min: {min}");

// (chisla)
//int startNum = int.Parse(Console.ReadLine());
//for (int i = 1; i <= startNum; i += 2)
//{
//    Console.WriteLine(i);
//}

// (chisla2)
//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//for (int i = 1; i < n; i += m)
//{
//    Console.WriteLine(i);
//}

// (broi text)
//string text = Console.ReadLine();
//int sum = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    char letter = text[i];
//    switch (letter)
//    {
//        case 'a':
//            break;
//            sum++;
//        case 'e':
//            sum += 2;
//            break;
//        case 'i':
//            sum += 3;
//            break;
//        case 'o':
//            sum += 4;
//            break;
//        case 'u':
//            sum += 5;
//            break;
//    }
//}
//Console.WriteLine(sum);

// (username i password)
//string username = Console.ReadLine();
//string password = Console.ReadLine();
//Console.WriteLine("Enter your password: ");
//string input = Console.ReadLine();
//while (input != password)
//{
//    Console.WriteLine("Wrong password! Try again!");
//    input = Console.ReadLine();
//}
//Console.WriteLine($"Welcome,{username}");

//(bankomat)
//int n = int.Parse(Console.ReadLine());
//double sum = 0;
//for (int i = 0; i < n; i++)
//{
//    double amount = double.Parse(Console.ReadLine());
//    if (amount < 0)
//    {
//        Console.WriteLine("Invalid!"); break;
//    }
//    Console.WriteLine($"Increase {amount}");
//    sum += amount;
//}
//Console.WriteLine($"Total: {sum:f2}");

//(Tablica za umn)

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j}= {i * j}");
//    }
//}
// (nova sgrada)
//int rows = int.Parse(Console.ReadLine());
//int cols = int.Parse(Console.ReadLine());
//for (int row = 1; row <= rows; row++)
//{
//    for (int col = 0; col < cols; col++)
//    {
//        Console.Write($"A{row}{col} ");
//    }
//    Console.WriteLine();
//}
