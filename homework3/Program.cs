//  ============= Задача 19 =============
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// ============= Задача 19 =============

// void Palindrom(int num)
// {          
//     int try1 = num / 10000; //первая
//     int try2 = num % 10; //пятая
//     int try3 = (num % 10000) / 1000; // вторая
//     int try4 = (num % 100) / 10; //четвертая

//     // int try5 = (num % 1000) / 100; //третья

//     // Console.Write($"{try1}, {try2}, {try3}, {try4}, {try5}");  
    
//     if (num < 100000 && num > 9999)
//     {
//         if (try1 == try2 && try3 == try4)
//         {           
//             Console.WriteLine($"{num} -> yes");         
//         }       
//         else 
//         {
//             Console.WriteLine($"{num} -> no"); 
//         }  
//     }
//     else Console.WriteLine($"Число {num} не является пятизначным! Введите, пож, пятизначное!"); 
     
// }
// Console.Write("Введите пятизначное число, мы определим, является ли оно палиндромом: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrom(num);

// ============= Задача 21 =============
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// ============= Задача 21 =============

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Distance( int x, int x1, int y, int y1, int z, int z1)
// {
//     double d = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));
//     Console.WriteLine($"Coordinates are: {x}, {x1}, {y}, {y1}, {z}, {z1}. Distance is: {Math.Round(d, 2)}");
// }
// Console.WriteLine("Давайте узнаем расстояние между кординатами в трехмерном пространстве!");
// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Distance(x, x1, y, y1, z, z1);

// ============= Задача 23 =============
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// ============= Задача 23 =============
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Давайте кубы всех чисел до заданного Вами!");
// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());

// void Cubes(int num)
// {
//     int num1 = 1;
//     while (num1 <= num)
//     {        
//         Console.Write(num1 * num1 * num1 + " ");
//         num1++;
//     }    
// }

// Console.Write(input  + " -> " );
// Cubes(input);

