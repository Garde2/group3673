// ============= Задача 54 =============
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// ============= Задача 54 =============

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

// int [,] FixingRowsByValue(int [,] array)
// {
//     int tempArray = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(0); k++)
//             {
//                 if (array[i, j] >= array[i, k])
//                 {
//                     tempArray = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = tempArray;
//                 }
//             }
//         }
//     }
//     return array;    
// }

// Console.WriteLine("Давайте создадим, а потом упорядочим по убыванию двумерный массив, с определённым Вами кол-вом рядов и столбцов!");
// Console.WriteLine();
// l1:Console.Write($"Введите кол-во рядов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int min = 0;
// int max = 10;

// if (m >= 0 && n >= 0)
//     {
//         int [,] array = Create2dRandomArray(m, n, min, max);
//         Show2DArray(array);
//         Show2DArray(FixingRowsByValue(array));
//     }
//     else
//     {
//         Console.Write($"Не может быть нулевой длины ряда или столбца!");goto l1;  
//     }   




// ============= Задача 56 =============
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// ============= Задача 56 =============

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

// void LowestSummString(int [,] array)
// {
//     int length = array.GetLength(1);
//     int [] summ = new int[length];     
//     int max = 0; 
//     int counter = 0; 
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {            
//             summ[i] += array[i, j];  
//             if(summ[i] > max)
//             {
//                 max = summ[i];
//                 counter = i;
//             }
//         }         
//     } 

//     Console.Write($" Ряд {counter + 1}");   
//     Console.Write($" имеет наибольшую сумму {max}."); 
//     Console.WriteLine();
      
// }

// Console.WriteLine("Давайте создадим, а потом упорядочим по убыванию двумерный массив, с определённым Вами кол-вом рядов и столбцов!");
// Console.WriteLine("Размерность рядов и столбцов будет совпадать и не должна равняться нулю!");
// l1:Console.Write($"Введите кол-во рядов: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int n = m;
// int min = 0;
// int max = 10;

// if (m >= 0)
//     {
//         int [,] array = Create2dRandomArray(m, n, min, max);
//         Show2DArray(array);
//         LowestSummString(array);
//     }
//     else
//     {
//         Console.Write($"Некорректная размерность!");goto l1;  
//     }   


// ============= Задача 58 =============
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// ============= Задача 58 =============


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

// int [,] MultiplyArrays(int [,] array1, int [,] array2)
// {   
//     int [,] multi = new int[array1.GetLength(0), array1.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)                //столбец
//         {
//             for (int j = 0; j < array1.GetLength(1); j++)        //строка
//             {
//                 multi[i, j] = 0;
//                 multi[i, j] += array1[i, j] * array2[i, j];                
//             }
//         }

//     return multi;
// }

// Console.WriteLine("Давайте создадим две матрицы и перемножим их, определите кол-во рядов и столбцов!");
// l1:Console.Write($"Введите кол-во рядов для матриц: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите кол-во столбцов для матриц: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int m2 = m1;
// int n2 = n1;
// int min = 0;
// int max = 10;

// if (m1 >= 0 && n1 >= 0 )
//     {
//         int [,] array1 = Create2dRandomArray(m1, n1, min, max);
//         int [,] array2 = Create2dRandomArray(m2, n2, min, max);
//         Show2DArray(array1);
//         Show2DArray(array2);
//         int [,] multiply = MultiplyArrays(array1, array2);
//         Show2DArray(multiply);        
//     }
//     else
//     {
//         Console.Write($"Некорректная размерность!");goto l1;  
//     }   


// ============= Задача 60 =============
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// ============= Задача 60 =============

// int [,,] Create3dRandomArray (int rows, int cols, int smth, int min, int max)
// {
//     int [,,] array = new int [rows, cols, smth];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             for (int k = 0; k < smth; k++)
//             {
//                 array[i, j, k] = new Random().Next(min+50, max + 1); 
                              
//             }            
//         }
//     } 

//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             for (int k = 0; k < smth; k++)
//             {
//                 if (array[i,j,k] != array[i,k,j] && array[k,i,j] != array[k,j,i] && array[j,i,k] != array[j,k,i])
//                 {
//                     return array;                   
//                 } 
//                 else
//                 {
//                     array[i,j,k] = new Random().Next(min, 49);
//                     // или array[i,j,k] +1; // но убрать +1 из максимума, то есть пыталась к совпадающим +1 добавлять(убрав "+1" из max+1)
//                     //еще пыталась на нули заменить, а потом в нули записать новые значения,
//                     // еще пыталась задавать в повторные рандом из другого интервала
//                     // все равно есть совпадающие в матрице 3х3. отчаялась
//                     // если только через кучу всего последовательно прогонять, но это ж бред. 
//                     // или юзать команду на уникальность (типа кто-то до меня уже родил как это сделать), но так не интересно
//                 }           
//             }            
//         }
//     } 
//     return array;

// }

// void Show3DArrayWithIndex(int [,,] array)
// {    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");  
//             }             
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Давайте создадим трехмерный массив определите кол-во рядов, столбцов и чего-то третьего!");
// l1:Console.Write($"Введите кол-во рядов: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите кол-во столбцов: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите кол-во чего-то третьего: ");
// int o1 = Convert.ToInt32(Console.ReadLine());

// int min = 10;
// int max = 99;

// if (m1 >= 0 && n1 >= 0 && o1 >= 0)
//     {
//         int [,,] array1 = Create3dRandomArray(m1, n1, o1, min, max);       
//         Show3DArrayWithIndex(array1);                
//     }
//     else
//     {
//         Console.Write($"Некорректная размерность!");goto l1;  
//     }   

// ============= Задача 62 =============
// Напишите программу, которая заполнит спирально массив 4 на 4.
// ============= Задача 62 =============
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//посмотрела решение в инете, теперь поняла принцип, хотя смутно догадывалась, как в 4х4 это решаемо,
//но про остаток от деления вообще не думала





