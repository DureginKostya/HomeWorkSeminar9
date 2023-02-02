/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Clear();
int GetDataFromUser(string msg)
{
    ColorizeText(msg, ConsoleColor.DarkGreen);
    int variable = 0;
    if (int.TryParse(Console.ReadLine()!, out variable) && variable > 0)
        return variable;
    return variable = GetDataFromUser("Введите повторно значение N (д.б. целочисленным и больше нуля): ");
}
void ColorizeText(string msg, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(msg);
    Console.ResetColor();
}
string GetRowOfNumbers(int value)
{
    if (value == 1)
        return value + "\"";
    return value + ", " + GetRowOfNumbers(value - 1);
}
int valueUser = GetDataFromUser("Введите значение N: ");
string rowNumbers = GetRowOfNumbers(valueUser);
ColorizeText($"N = {valueUser} -> \"" + rowNumbers, ConsoleColor.DarkYellow);
Console.WriteLine();