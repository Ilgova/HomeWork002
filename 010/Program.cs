// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трёхзначное число: ");
int TwoNumber = Convert.ToInt32(Console.ReadLine());
if (TwoNumber < 1000)
    {
        TwoNumber = TwoNumber / 10 % 10;  
    Console.WriteLine("вторая цифра трехзначного числа " + TwoNumber);
    }
else
    Console.WriteLine("введено не корректное число");

