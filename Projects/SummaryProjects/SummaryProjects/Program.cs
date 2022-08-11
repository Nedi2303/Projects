//int count = int.Parse(Console.ReadLine());
//int max = -10000;
//int min = 10000;
//for (int i = 0; i < count; i++)
//{
//    int num = int.Parse(Console.ReadLine());
//    if (num > max)
//    {
//        max = num;
//    }
//    if (num < min)
//    {
//        min = num;
//    }

//}
//Console.WriteLine($"Max: {max}");
//Console.WriteLine($"Min: {min}");

//int n= int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i+=3)
//{
//    Console.WriteLine(i);

//string text = Console.ReadLine();
//int sum = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    char letter = text[i];


//    switch (letter)
//    {
//        case 'a':
//            sum++;
//            break;
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

//string username = Console.ReadLine();
//string password = Console.ReadLine();
//Console.WriteLine("Enter your password:");
//string input= Console.ReadLine();
//while (input != password)
//{
//    Console.WriteLine("Wrong password, try again!");
//    input = Console.ReadLine();
//}
//Console.WriteLine($"Welcome, {username}");

//int n = int.Parse(Console.ReadLine());
//double sum = 0;
//for (int i = 0; i < n; i++)
//{
//    double amount = double.Parse(Console.ReadLine());
//    if (amount < 0)
//    {
//        Console.WriteLine("Invalid");
//        break;
//    }
//    Console.WriteLine($"Increase: {amount}");
//    sum += amount;
//}
//Console.WriteLine($"Total: {sum}");

//int rows = int.Parse(Console.ReadLine());
//int cols = int.Parse(Console.ReadLine());

//for (int row = rows; row >= 1; row--)
//{
//    string type = "A";
//    if (row % 2 == 0)
//    {
//        type = "O";
//    }
//    if (row == rows)
//    {
//        type = "L";
//    }
//    for (int col = 0; col < cols; col++)
//    {
//        Console.Write($"{type}{row}{col} ");
//    }
//    Console.WriteLine();
//}

//int n = int.Parse(Console.ReadLine());
//int num = 1;

//for (int row = 1; row <= n; row++)
//{
//    bool flag = false;
//    for (int col = 1; col <= row; col++)
//    {
//        if (num > n)
//        {
//            flag = true;
//            break;
//        }
//        Console.Write($"{num} ");
//        num++;
//    }
//    Console.WriteLine();
//    if (flag)
//    {
//        break;
//    }
//}

//int n = int.Parse(Console.ReadLine());
//for (int row = 1; row <= n; row++)
//{
//    int spaces = n - row;
//    for (int count = 0; count < spaces; count++)
//    {
//        Console.Write(" ");
//    }
//    for (int col = 1; col <= row; col++)
//    {
//        Console.Write("* ");
//    }

//    Console.WriteLine();
//}
//for (int row = n-1; row >= 1; row--)
//{
//    int spaces = n - row;
//    for (int count = 0; count < spaces; count++)
//    {
//        Console.Write(" ");
//    }
//    for (int col = 1; col <= row; col++)
//    {
//        Console.Write("* ");
//    }

//    Console.WriteLine();
//}


