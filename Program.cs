// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// РЕШЕНИЕ:

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int colums = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, colums, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);

// int[,] GetArray (int m, int n, int min, int max){
//     int[,] result = new int[m, n];
//     for(int i=0; i<m; i++){
//         for(int j=0; j<n; j++){
//             result[i, j] = new Random().Next(min, max +1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray){
//     for(int i=0; i <inArray.GetLength(0); i++){
//         for(int j=0; j <inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array){
//     for(int i=0; i <array.GetLength(0); i++){
//         for(int j=0; j <array.GetLength(1); j++){
//             for(int t=j+1; t<array.GetLength(1); t++ ){
//                 if(array[i,t] > array[i,j]){
//                     int temp = array[i,j];
//                     array[i,j] = array[i,t];
//                     array[i,t] = temp;
//                 }
//             }
//         }
//     }
// }
// __________________________________________________________________________________________________________________________________________________________________
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// РЕШЕНИЕ:

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int colums = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, colums, 0, 10);
// PrintArray(array);

// Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

// int[,] GetArray (int m, int n, int min, int max){
//     int[,] result = new int[m, n];
//     for(int i=0; i<m; i++){
//         for(int j=0; j<n; j++){
//             result[i, j] = new Random().Next(min, max +1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray){
//     for(int i=0; i <inArray.GetLength(0); i++){
//         for(int j=0; j <inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int GetRowNumber (int [,] array){
//     int row = 0;
//     int minus = 0;
//     for(int i=0; i<array.GetLength(1); i++){
//         minus = minus + array[0,i];
//     }
//     for(int i=1; i<array.GetLength(0); i++){
//         int sum =0;
//         for (int j=0; j < array.GetLength(1); j++){
//             sum = sum+array[i,j];
//         }
//         if (minus>sum){
//             minus=sum;
//             row=i;
//         }
//     }
//     return row;
// }

// __________________________________________________________________________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.Write("Введите количество строк 1 массива: ");
// int rowsA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов 1 массива: ");
// int columsA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество строк 2 массива: ");
// int rowsB = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов 2 массива: ");
// int columsB = int.Parse(Console.ReadLine()!);
// if(columsA != rowsB){
//     Console.WriteLine("Такие матрицы умножить нельзя!");
//     return;
// }

// int[,] A = GetArray(rowsA, columsA, 0, 10);
// int[,] B = GetArray(rowsB, columsB, 0, 10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultiMatrix(A,B));

// int[,] GetArray (int m, int n, int min, int max){
//     int[,] result = new int[m, n];
//     for(int i=0; i<m; i++){
//         for(int j=0; j<n; j++){
//             result[i, j] = new Random().Next(min, max +1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray){
//     for(int i=0; i <inArray.GetLength(0); i++){
//         for(int j=0; j <inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetMultiMatrix(int[,] arrayA, int[,] arrayB){
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for(int i=0; i<arrayA.GetLength(0); i++){
//         for(int j=0; j<arrayB.GetLength(1); j++){
//             for(int k=0; k<arrayA.GetLength(1); k++){
//                 arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
//             }
//         }
//     }
//     return arrayC;
// }