/* 
Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int rows = ReadInt("Введите количество строк массива: ");
int colums = ReadInt("Введите количество столбцов массива: ");
double[,] numbers = new double[rows, colums];
FillArray(numbers);
PrintArray(numbers);

// Функция ввода данных
int ReadInt(string message)
{
    Console.Write(message);
    int read = Convert.ToInt32(Console.ReadLine());
    return read;
}

//  Функция вывода массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Заполнение массива рандомными вещественными числами
void FillArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
             Random rnd = new Random();
             array[i, j] = rnd.NextDouble() * 10;
        }
    }
}


