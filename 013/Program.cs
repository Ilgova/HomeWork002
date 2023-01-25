// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 100)
    {
        Number = Number % 10;
    Console.WriteLine("третья цифра числа " + Number);
    }
else
    Console.WriteLine("третьей цифры нет");