// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите цифру от 1 до 7, обозначающую день недели ");
int NumberС = int.Parse(Console.ReadLine());
if (NumberС < 1 || NumberС > 7)
Console.WriteLine("Введенное число не соотвествует дню недели");
else
if (NumberС == 6 || NumberС == 7)
Console.WriteLine("Да");   
else
Console.WriteLine("Нет");
