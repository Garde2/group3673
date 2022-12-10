// ============= Задача 25 =============
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// ============= Задача 25 =============

// Console.WriteLine("Давайте возведем выбранное Вами число в указанную Вами степень!");
// Console.Write("Введите число, которое будем возводить: ");
// int varA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите cтепень: ");
// int varB = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{varA}, {varB} -> ");

// int Degr(int inputA, int inputB)
// {
//     if (inputB < 0)
//     {
//         inputB = inputB * -1;
//     }    
//     int res = 1;
//     for (int i = 1; i <= inputB; i++)
//     {
//         res = inputA * res;               
//     }      
//     return res;  
// }

// int res = Degr(varA, varB);
// Console.Write(res);

// ============= Задача 27 =============
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
// ============= Задача 27 =============

// Console.WriteLine("Давайте найдем сумму цифр в выбранном Вами числе!");
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{num} -> ");

// int SummNumbers(int x)
// {
//     int res = 0;
//     if (x == 0) 
//     {        
//         return 1;
//     }
//     else
//     {
//         while (x != 0)  
//         {
//             res += x % 10;       ///Нашла, наконец-то, как решить без прописывания лимитов (как в задаче одного из прошлых дз), я не додумалась сама.
//             x = x / 10;
//         }
//         return res;   
//     }     
// }

// int res = SummNumbers(num);
// Console.Write(res);

// ============= Задача 29 =============
//Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// ============= Задача 29 =============
// сколько элем массива
//предаем в функцию массива
//в ней спрашивать про каждое число
//распечататать введенные и сам массив

Console.WriteLine("Давайте создадим массив, длину и наполнение которого Вы сами определите");
Console.Write("Введите длину массива: ");
int massLength = Convert.ToInt32(Console.ReadLine());
//Console.Write($"{num} -> ");


int[] Array()
{
    int [] arr = new int [massLength];
    for (int i = 0; i < massLength; i++)
    {        
        Console.Write("Введите число для заполнения массива: ");
        arr[i] = int.Parse(Console.ReadLine());        
    }
    return arr;
}
void ShowArray (int[] arr)
{
    foreach( int i in arr) Console.Write(i + " ");
    Console.Write("-> ");
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {        
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }                
    }
    Console.Write("]");    
}

ShowArray(Array());

//PS Больше всего времени ушло на то, чтоб привести вывод в вид, как на образце в дз %)




