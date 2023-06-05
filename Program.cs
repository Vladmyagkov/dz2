// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1;

// for(int i=1; i<num2; i++)
// {
//     result = result*num1;
// }
// Console.Write(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while(num>0)
// {
//     int a = num % 10;
//     num = num/10;
//     sum = sum + a;
// }
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] num = new int[8];

// for(int i = 0; i< num.Length; i++)
// {
//     num[i] = new Random().Next(0, 10);
//     Console.Write($"{num[i]} ");
// }