/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Clear();
int GetDataFromUser(string msg, string value)
{
    ColorizeText(msg, ConsoleColor.DarkCyan);
    int variable = -1;
    if (int.TryParse(Console.ReadLine()!, out variable) && variable >= 0)
        return variable;
    return variable = GetDataFromUser($"Введите повторно значение {value} (д.б. целочисленным и не меньше нуля): ", value);
}
void ColorizeText(string msg, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(msg);
    Console.ResetColor();
}
int GetSumFromMToN(int initialValue, int finalValue)
{
    if (initialValue == finalValue)
        return initialValue;
    return initialValue += GetSumFromMToN(initialValue + 1, finalValue);
}
int valueM = GetDataFromUser("Введите значение M: ", "M");
int valueN = GetDataFromUser("Введите значение N: ", "N");
if (valueM < valueN)
{
    int sum = GetSumFromMToN(valueM, valueN);
    ColorizeText($"Сумма натуральных элементов в промежутке от {valueM} до {valueN} равна {sum}", ConsoleColor.White);
    Console.WriteLine();
}
else
    ColorizeText($"Невозможно вычислить сумму натуральных элементов в промежутке от {valueM} до {valueN}", ConsoleColor.DarkRed);