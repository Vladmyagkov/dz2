// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] arr = new double [rows, columns];

// // Заполняем наш массив
// void Fillarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int g = 0; g < arr.GetLength(1); g++)
//         {
//             arr[i,g] =  Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }


// // Вывод нашего массива
// void Printarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int g = 0; g < arr.GetLength(1); g++)
//         {
//             Console.Write(arr[i,g]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Fillarr();
// Printarr();


// ________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите номер стлобца:");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] arr = new double [10, 5];

// // Заполняем наш массив
// void Fillarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int g = 0; g < arr.GetLength(1); g++)
//         {
//             arr[i,g] =  Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }


// // Вывод нашего массива
// void Printarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int g = 0; g < arr.GetLength(1); g++)
//         {
//             Console.Write(arr[i,g]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// // Вывод элемента

// void Printelement()
// {
//     if (rows > arr.GetLength(0) || columns > arr.GetLength(1))
//     {
//         Console.WriteLine("такого элемента нет");
//     }
//     else
//     {
//         Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {arr[rows-1,columns-1]}");
//     }
// }

// Fillarr();
// Printarr();
// Printelement();


// ______________________________________________________________________________________________

// Задача 52. Задайте двумерный 
// массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.


Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [rows, columns];

// Заполняем наш массив
void Fillarr()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int g = 0; g < arr.GetLength(1); g++)
        {
            arr[i,g] =  new Random().Next(-100, 100);
        }
    }
}


// Вывод нашего массива
void Printarr()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int g = 0; g < arr.GetLength(1); g++)
        {
            Console.Write(arr[i,g]+ " ");
        }
        Console.WriteLine();
    }
}

void Meancolumns()
{
    for (int g = 0; g < arr.GetLength(1); g++)
    {
        double mean = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            mean += arr[i,g];
        }
        Console.Write($"Среднеарифметическое: {mean / arr.GetLength(0)}; ");
    }
}

Fillarr();
Printarr();
Meancolumns();