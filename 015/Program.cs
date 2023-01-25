// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7");
int NumberDay = Convert.ToInt32(Console.ReadLine());

if  (NumberDay == 6 || NumberDay == 7)
 {
    Console.WriteLine("Да");
 } 
    
else if (NumberDay < 1 || NumberDay > 7)
    {
        Console.WriteLine("Недопустимое значение. Попробуйте ещё раз");
 } 
else 
Console.WriteLine("нет");