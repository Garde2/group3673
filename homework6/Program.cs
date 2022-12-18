// ============= Задача 41 =============
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// ============= Задача 41 =============

// int [] CreateArray(int size)
// {
//     int [] array = new int[size];
//     int i = 0;
//     while (i < size)    
//     {
//         Console.Write("Введите число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         i++;        
//     }
//     return array;
// }

// void MoreZero(int [] array, int size)
// {           
//     int count = 0;    
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++; 
//         }                    
//     }
//     Console.Write($"{count}"); 
      
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

// Console.WriteLine("Давайте введем сколько-то числел и определим, сколько из них > 0!");
// Console.Write("Сколько чисел Вы будете вводить? ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array4ik = CreateArray(size);
// ShowArray(array4ik);
// MoreZero(array4ik, size);


// ============= Задача 43 =============
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// ============= Задача 43 =============
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void Crossing(int b1, int k1, int b2, int k2)
// {
//     int x = -(b1 - b2) / (k1 - k2);   //жесть!!!!!!!!
//     int y = k1 * x + b1;
    
//     Console.WriteLine($"Coordinates are: {x}, {y}");
// }
// Console.WriteLine("Давайте найдем точку пересечения двух прямых!");
// Console.WriteLine("Вам нужно будет ввести четыре значения!");
// Console.Write("Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());


// Crossing(b1, k1, b2, k2);
