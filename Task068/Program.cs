/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Clear();
int GetDataFromUser(string msg, string value)
{
    ColorizeText(msg, ConsoleColor.White);
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
double GetSumFromMToN(double numberM, double numberN)
{
    if (numberM == 0)
        return numberN += 1;
    if (numberM > 0 && numberN == 0)
        return numberN = GetSumFromMToN(numberM - 1, 1);
    if (numberM > 0 && numberN > 0)
        return numberN = GetSumFromMToN(numberM - 1, GetSumFromMToN(numberM, numberN - 1));
    return numberN;
}
ColorizeText("\t" + "!!! Вычисление функции Аккермана - A(m,n) !!!", ConsoleColor.Magenta);
Console.WriteLine();
int valueM = GetDataFromUser("Введите значение m: ", "m");
int valueN = GetDataFromUser("Введите значение n: ", "n");
double functionAkkerman = GetSumFromMToN(valueM, valueN);
ColorizeText($"Функция Аккермана - А({valueM},{valueN}) = {functionAkkerman}", ConsoleColor.Yellow);
Console.WriteLine();
