// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите положительно число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 == 0)
{
    Console.WriteLine($"В числе {num} третья цифра отсутсвует");
    return;
}
int num1 = num; 
while (num1 /100 > 10)
{
    num1 = num1 / 10;
}
int result = num1 % 10;
if (num1 > 0)
{
    Console.WriteLine($"В числе {num1} третья цифра {result}");
}
