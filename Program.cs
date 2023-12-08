
//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// int ReadInt(string text)
// {
// System.Console.Write(text);
// return Convert.ToInt32(Console.ReadLine());
// }
// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");

// int[,] numbers = new int[10, 10];
// FillArray(numbers);
// PrintArray(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
//     Console.WriteLine(numbers[rows, colums]);
// else
//     Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

// void FillArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = new Random().Next(1, 10);
// }
// }
// }

// void PrintArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i, j] + " ");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

// int ReadInt(string text)
// {
// System.Console.Write(text);
// return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
// {
// int[,] tempMatrix = new int[row, col];
// Random rand = new Random();

// for (int i = 0; i < tempMatrix.GetLength(0); i++)
// {
// for (int j = 0; j < tempMatrix.GetLength(1); j++)
// {
// tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
// }
// }

// return tempMatrix;
// }

// void PrintMatrix(int[,] matrixForPrint)
// {
// for (int i = 0; i < matrixForPrint.GetLength(0); i++)
// {
// for (int j = 0; j < matrixForPrint.GetLength(1); j++)
// {
// System.Console.Write(matrixForPrint[i, j] + "\t");
// }
// System.Console.WriteLine();
// }
// }

// void SwapOfRows(int[,] matrix)
// {
//     int temp;
//     for(int i = 0; i < matrix.GetLength(1); i++)
//     {
//         temp = matrix[0,i];
//         matrix[0,i] = matrix[matrix.GetLength(0)-1, i];
//         matrix[matrix.GetLength(0)-1, i] = temp;
//     }
// }

// // ------------------------------------------

// int rows = ReadInt("Введите количество строк массива: ");
// int cols = ReadInt("Введите количество столбцов массива: ");

// // Заполнение массива
// int[,] matrix = GenerateMatrix(rows, cols, -9, 9);

// // Вывод массива
// PrintMatrix(matrix);
// Console.WriteLine();

// SwapOfRows(matrix);
// PrintMatrix(matrix);

// // int val1 = ReadInt("Введите строку: ");
// // int val2 = ReadInt("Введите столбец: ");


// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

// int ReadInt(string text)
// {
// System.Console.Write(text);
// return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
// {
// int[,] tempMatrix = new int[row, col];
// Random rand = new Random();

// for (int i = 0; i < tempMatrix.GetLength(0); i++)
// {
// for (int j = 0; j < tempMatrix.GetLength(1); j++)
// {
// tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
// }
// }

// return tempMatrix;
// }

// void PrintMatrix(int[,] matrixForPrint)
// {
// for (int i = 0; i < matrixForPrint.GetLength(0); i++)
// {
// for (int j = 0; j < matrixForPrint.GetLength(1); j++)
// {
// System.Console.Write(matrixForPrint[i, j] + "\t");
// }
// System.Console.WriteLine();
// }
// }
// void SumStringMatrix(int[,] matrix)
// {
//     int index = 0, minsum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         Console.WriteLine($"Сумма элементов {i + 1} строки = {sum}");
//         if (i == 0)
//         {
//             minsum = sum;
//         }
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
//     }
//     string line = string.Empty;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         line += matrix[index, j] + " ";
//     }
// Console.WriteLine($"Строка с индексом {index}. ");
// }

// // ------------------------------------------

// int rows = ReadInt("Введите количество строк массива: ");
// int cols = ReadInt("Введите количество столбцов массива: ");

// // Заполнение массива
// int[,] matrix = GenerateMatrix(rows, cols, -9, 9);

// // Вывод массива
// PrintMatrix(matrix);
// SumStringMatrix(matrix);

