﻿// Добавить в новый массив строки длиной равной или менее 3х символов.

Console.Clear();
Console.Write("Введите строковые элементы массива: ");

string? input = Console.ReadLine();

string[] array = input.Split(' ');

Console.WriteLine($"Массив строк: [{string.Join(",", array)}]");

int newarrlen = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarrlen++;
    }
}
Console.WriteLine($"Длина нового массива:{newarrlen}");

string[] newarr = new string[newarrlen];
int l = 0;
for (int s = 0; s < array.Length; s++)
{
    if (array[s].Length <= 3)
    {
        newarr[l] = array[s];
        l++;
    }
}
Console.WriteLine($"Массив строк c учетом условия задачи: [{string.Join(",", newarr)}]");