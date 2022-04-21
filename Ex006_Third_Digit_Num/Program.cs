
// Задача 6. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//int num=645;
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num=Math.Abs(num);

 if (num >= 100)
 {
    String text = Convert.ToString(num);
    string result = text.Substring(2,1);
    Console.Write("Третья цифра ");
    Console.WriteLine(result);
 }

else
{
    Console.WriteLine("третьей цифры нет");
}

