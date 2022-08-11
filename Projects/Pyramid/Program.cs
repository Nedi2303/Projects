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

//    if (flag)
//    {
//        break;
//    }

//    Console.WriteLine();
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
//for (int row = n - 1; row >= 1; row--)
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