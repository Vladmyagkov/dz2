// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] arr = new int [rows, columns];

// // Заполняем наш массив
// void Fillarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int g = 0; g < arr.GetLength(1); g++)
//         {
//             arr[i,g] =  new Random().Next(-100, 100);
//         }
//     }
// }


// // Вывод нашего массива
// void Printarr(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int g = 0; g < result.GetLength(1); g++)
//         {
//             Console.Write(result[i,g]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void Sortarr()
// {   for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < arr.GetLength(1) - 1; z++)
//             {
//                 if (arr[i, z] < arr[i, z + 1])
//                 {
//                     int temp = 0;
//                     temp = arr[i, z];
//                     arr[i, z] = arr[i, z + 1];
//                     arr[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// }
// Fillarr();
// Printarr(arr);
// Console.WriteLine("Отсортированный массив");
// Sortarr();
// Printarr(arr);



// ____________________________________________________________________________________________-


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов отличающееся от кол-ва строк:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] arr = new int [rows, columns];
// int minsum = Int32.MaxValue;
// int indexLine = 0;

// // Заполняем наш массив
// void Fillarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int g = 0; g < arr.GetLength(1); g++)
//         {
//             arr[i,g] =  new Random().Next(-100, 100);
//         }
//     }
// }


// // Вывод нашего массива
// void Printarr(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int g = 0; g < result.GetLength(1); g++)
//         {
//             Console.Write(result[i,g]+ " ");
//         }
//         Console.WriteLine();
//     }
// }


// void Sumarr()
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum = sum + arr[i, j];        
//         }
//         if (sum < minsum)
//         {
//             minsum = sum;
//             indexLine++;
//         }
//     }
// }

// Fillarr();
// Printarr(arr);
// Sumarr();
// Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

// _____________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void FillArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5);
//         }
//     }
// }

// void PrintArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Console.WriteLine("размерность матриц: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArr(matrixA);
// FillArr(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArr(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArr(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArr(matrixC);



// _________________________________________________________________________________________________

// Задача 60. ...Сформируйте трёхмерный 
// массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите сторону 1:");
// int deep1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите сторону 2:");
// int deep2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите сторону 3:");
// int deep3 = Convert.ToInt32(Console.ReadLine());
// int countNums = 89;

// if (deep1 * deep2 * deep3 > countNums)
// {
//     Console.Write("Массив слишком большой");
//     return;
// }

// int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }


// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }