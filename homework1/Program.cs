//Дубль два. странно, что не запушилось с первого раза, я проверяла в терминале статус, всё было ок...

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Давайте введем два числа и определим, какое больше?");
// Console.WriteLine("Введите целое натуральное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое натуральное число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if ( a < b)
// {
//     Console.WriteLine($" Первое число = {a}, второе число = {b}. {b} > {a}. Max => {b}");
// }
// else
// {
//     {
//         Console.WriteLine($" Первое число = {a}, второе число = {b}. {a} > {b}. Max => {a}");
//     }
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Давайте введем три целых числа и определим наибольшее?");
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (a < b && b < c)
// {
//     max = c;
// }
// if (c < b && a < b)
// {
//     max = b;
// }

// Console.WriteLine($" {a}, {b}, {c}. Max => {max}");

// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Давайте введем целое число и определим четное ли оно?");
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if ( a % 2 == 0)
// {
//     Console.WriteLine($"{a} => yes");
// }
// else 
// {
//     Console.WriteLine($"{a} => no");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Давайте введем целое число и определим все четные числа от 1 до этого числа?");
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

// вариант с for (простите :)

// if (n != 1)
// {
//     for (int i = 2; i <= n; i += 2) 
//     {        
//         Console.Write(i + " ");
//     }    
// }
// else
//     Console.Write($"Вы ввели число {n}.  До него нет чётных чисел.");


//вариант с while, предположим, что в промежутке, включая число "n".

int count = 1;

if ( n == 1)
{
    Console.Write($"Вы ввели число {n}.  До него нет чётных чисел.");
}
else
{
    while (count <= n)
    {
        if (count % 2 != 0)
        {
             count++ ; // count = count + 1; 
        
        }
        else 
        {
                Console.Write(count + " "); 
                count++ ;
        }
    }
}








