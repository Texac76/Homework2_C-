// Задача 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int a = new Random().Next(16, 16);
int b = new Random().Next(4, 4);

System.Console.WriteLine(a);
System.Console.WriteLine(b);

//Console.ReadLine();
void f(int x, int y)

{
    if (x == y * y || y == x * x)
    {

        Console.WriteLine("Да");
    }

    else
    {
        Console.WriteLine("Нет");
    }

}

f(a, b);