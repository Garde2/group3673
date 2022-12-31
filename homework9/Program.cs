// ============= Задача 60 =============
// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
// ============= Задача 60 =============

// боже, как?!

void Transliter(int m)
{    
    if (m / 2 > 0)
    {
        Transliter(m / 2);
        Console.Write(m + " ");
    }
    else
    {
        Transliter(m % 2);
        Console.Write(m + " ");
    }
}


// Console.WriteLine("Переведем число из десятичной системы в двоичную!");
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
int m = 78;
Console.Write($"Ваше число - {m}, в двоичной системе это -> ");

Transliter(m);


// ============= Задача 60 =============
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ============= Задача 60 =============
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// void SummNumbersMN(int m, int n, int temper)
// {    

//     if(m == 0 && n == 0)
//     {
//         Console.Write("0"); 
//     }
//     if( m == n)
//     {
//         Console.Write($"{temper} ");
//     }
    
//     if (m > n)
//     { 
//         Console.Write(" ");
//     //     l1:SummNumbersMN(m + 1, n, temper + m + 1);
//     //     Console.Write($"{temper} ");  
//     //     int smth = m;              
//     //     m = m;
//     //     n = smth; goto l1;  
//     } 
//     if (m <= n)
//     {     
//         // Console.Write($"m = {m}, ");    
//         // Console.Write($" temp = {temper}, ");
//         SummNumbersMN(m + 1, n, temper + m + 1);
//         //Console.Write($"{temper} ");  
//     }
// }

// Console.WriteLine("Найдём сумму натуральных элементов в промежутке от M до N!");
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"М = {m}, N = {n} => ");

// int temper = m;
// SummNumbersMN(m, n, temper);





