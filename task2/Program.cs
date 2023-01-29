/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int rows = ReadInt("Введите строку массива: ");
int colums = ReadInt("Введите столбец массива: ");
// Функция ввода данных
int ReadInt(string message)
{
    Console.Write(message);
    int read = Convert.ToInt32(Console.ReadLine()) - 1;
    return read;
}
Random random = new Random();
int[,] arr = new int[5, 7];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 100);
        Console.Write("{0} ", arr[i, j]);
    }

Console.WriteLine();
}

if (rows < 0 | rows > arr.GetLength(0) - 1 | colums < 0 | colums > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[rows, colums]);
}
