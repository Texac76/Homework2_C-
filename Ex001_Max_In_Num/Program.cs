
// Задача 1. Напишите метод, который выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int a = new Random().Next(10, 100);
// Console.WriteLine(a);

// Console.ReadKey();

// int b = a % 10;
// int c = a / 10;
// //Console.WriteLine(b);
// //Console.WriteLine(c);
// int max;
// if (b > c)
// {
//     max = b;
// }
// else
// {
//     max = c;
// }
// Console.WriteLine(max);

int a = new Random().Next(10, 100);
Console.WriteLine(a);

int FindMax(int value)
{
    int b = value % 10;
    int c = value / 10;
//Console.WriteLine(b);
//Console.WriteLine(c);
int max;
if (b > c)
{
    max = b;
}
else
{
    max = c;
}
//Console.WriteLine(max);
return (max);
}

int result = FindMax(a);
Console.WriteLine(result);
//FindMax(value: a) // - так тоже можно записать