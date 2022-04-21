// Задача 7 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


int day = new Random().Next(1, 8);

System.Console.WriteLine(day);

//Console.ReadLine();
void f(int x)

{
    if (x == 6 || x == 7)
    {

        Console.WriteLine("Да");
    }

    else
    {
        Console.WriteLine("Нет");
    }

}

f(day);