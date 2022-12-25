
// ============= Задача 47 =============
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ============= Задача 47 =============

// double [,] Create2dRandomArray (int rows, int cols, double min, double max)
// {
//     double [,] array = new double [rows, cols];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().NextDouble() * (max - min) + min; // min <= array[i] <= max
//         }
//     }

//     return array;
// }

// void Show2DArray(double [,] array)
// {    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,6:F1}", array[i,j]); //  "{0,6:F1}" - знаки после запятой при выводе            
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"Давайте создадим и выведем на экран двумерный массив, с определённым Вами кол-вом рядов и столбцов, min и max значениями!");
// Console.Write($"Введите кол-во рядов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите минимальное значение в массиве: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Введите максимальное значение в массиве: ");
// double max = Convert.ToDouble(Console.ReadLine());

// double [,] array = Create2dRandomArray(m, n, min, max);
// Console.WriteLine($" min = {min}, max = {max}");
// Show2DArray(array);

// ============= Задача 50 =============
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ============= Задача 50 =============

// int [,] Create2dRandomArray (int rows, int cols, int min, int max)
// {
//     int [,] array = new int [rows, cols];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max + 1) ; 
//         }
//     }

//     return array;
// }

// void Show2DArray(int [,] array)
// {    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");  
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Давайте создадим и выведем на экран двумерный массив, с определённым Вами кол-вом рядов и столбцов, min и max значениями!");
// Console.WriteLine("А потом введем координаты и узнаем значение элемента!");
// Console.Write($"Введите кол-во рядов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите минимальное значение в массиве: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите максимальное значение в массиве: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите индекс ряда: ");
// int rowsNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите индекс столбца: ");
// int colsNum = Convert.ToInt32(Console.ReadLine());
// if (rowsNum != 0 && colsNum != 0)
//     {
//         int [,] array = Create2dRandomArray(m, n, min, max);
//         Show2DArray(array);
//         Console.WriteLine($" Ряд - {rowsNum}, столбец - {colsNum}.");
//         if (rowsNum <= array.GetLenght(0) &&  colsNum <= array.GetLenght(1))
//         {
//             Console.Write(" Значение по индексу -> ", array[rowsNum - 1,colsNum- 1]);     //предполагаем, что считаем нормально, с 1 , не с нуля.  
//         }         
//         else 
//         {
//             Console.Write($"Значения с такими координатами не существует!");        
//         } 
//     }    
//     else 
//     {
//         Console.Write($"Нулевых ряда и столбца не существует!");        
//     } 


// ============= Задача 52 =============
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ============= Задача 52 =============

int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min, max + 1) ; 
        }
    }

    return array;
}

void Show2DArray(int [,] array)
{    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CountingAverageSummInEveryRow(int [,] array, int m, int n)
{   
    double [] summ = new double[m];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[i] += array[j, i];
        }        
    }
    foreach (double elem in summ)
    {
        Console.Write("{0,6:F1}", elem/n);
    }
}

Console.WriteLine("Давайте создадим и выведем на экран двумерный массив, с определённым Вами кол-вом рядов и столбцов!");
Console.WriteLine("А потом узнаем среднее арифметическое в каждом столбце!");
Console.Write($"Введите кол-во рядов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int min = 0;
int max = 10;

int [,] array = Create2dRandomArray(m, n, min, max);
Show2DArray(array);
Console.Write("Средние арифметические -> ");
CountingAverageSummInEveryRow(array, m, n);

