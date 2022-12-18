// ============= Задача 34 =============
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// ============= Задача 34 =============

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);        
//     }
//     return array;
// }
// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     foreach (var item in array) 
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.Write("] -> ");
// }

// int EvenNum(int [] array)
// {
//     int even = 0;
//     foreach (int i in array) 
//     {
//         if (i % 2 == 0)
//         {
//             even++;
//         }        
//     }           
//     return even;
// }

// int min = 100;
// int max = 999;
// int size = 10;
// int [] array4ik = CreateArray(size, min, max);
// ShowArray(array4ik);
// Console.WriteLine(EvenNum(array4ik));

// ============= Задача 35 =============
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// ============= Задача 35 =============

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);        
//     }
//     return array;
// }
// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     foreach (var item in array) 
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.Write("] -> ");
// }

// int IntervalNum(int [] array)
// {
//     int even = 0;
//     foreach (int i in array) 
//     {
//         if (i > 9 && i < 100)
//         {
//             even++; 
//         }
                     
//     }           
//     return even;
// }

// int min = -1000;
// int max = 1000;
// int size = 123;
// int [] array4ik = CreateArray(size, min, max);
// ShowArray(array4ik);
// Console.WriteLine(IntervalNum(array4ik));

// ============= Задача 36 =============
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// ============= Задача 36 =============

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);        
//     }
//     return array;
// }
// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     foreach (var item in array) 
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.Write("] -> ");
// }

// int OddSummNum(int [] array)
// {
//     int odd = 0;
//     for(int i = 1; i < array.Length; i +=2)
//     {
//         odd = odd + array[i];
//     }           
//     return odd;
// }

// int min = -10;
// int max = 10;
// int size = 10;
// int [] array4ik = CreateArray(size, min, max);
// ShowArray(array4ik);
// Console.WriteLine(OddSummNum(array4ik));

// ============= Задача 38 =============
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// ============= Задача 38 =============

// [3 7 22 2 78] -> 76

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);        
//     }
//     return array;
// }
// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     foreach (var item in array) 
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.Write("] -> ");
// }

// int WhatMax(int [] array)
// {
//     int maximum = int.MinValue;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (maximum < array[i])
//         {
//             maximum = array[i];
//         }    
//     }
//     return maximum;
// }

// int WhatMin(int [] array)
// {
//     int minimum = int.MaxValue;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (minimum > array[i])
//         {
//             minimum = array[i];
//         }    
//     }
//     return minimum;
// }

// int Difference(int maximum, int minimum)
// {  
//     int diff = maximum - minimum;    
//     return diff;
// }

// int min = -10;
// int max = 10;
// int size = 4;

// int [] array4ik = CreateArray(size, min, max);
// ShowArray(array4ik);
// int maximum = WhatMax(array4ik);
// int minimum = WhatMin(array4ik);
// int diff = Difference(maximum, minimum);
// Console.Write($"Max - {maximum}, min = {minimum}. Max - min = {diff}.");
// //или без метода дифференс и без строк 193 и 194 просто:
// // Console.Write($"Max - {maximum}, min = {minimum}. Max - min = {maximum - minimum}.");

// ============= Задача 37 =============
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// ============= Задача 37 =============


// не получилась.  сначала делала через иф, чтоб прописать для нечетной длины и четной, потом попыталась вообще просто
//чтоб перемножалось и пыталось, но снова так же ошибка, что не может явно массив в интеджер и вторая, что интеджер в массив, я не понимаю,в  чем дело.
//не шмогла.
// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);        
//     }
//     return array;
// }
// void ShowArray(int [] array)
// {
//     Console.Write("[");
//     foreach (var item in array) 
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.Write("] -> ");
// }

// int Multiply(int [] array, int size)
// {
//     int [] new_array = new int[size];
//     new_array[0] = array[0] * array[size];
//     int j = 0;  
            
//     for (int i = 0; i < size; i++)
//     {
//         new_array[j++] = array[i + 1] * array[size - 1];        
//     }
//     return new_array;
// }

// int min = -10;
// int max = 10;
// int size = 10;

// int [] array4ik = CreateArray(size, min, max);
// int [] new_array = Multiply(array4ik, size);
// ShowArray(array4ik);
// ShowArray(new_array);

