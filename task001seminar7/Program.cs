//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine($"Создаем двумерный массив , заполненный случайными вещественными числами.");
Console.WriteLine("");
Console.WriteLine("Введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
double[,] Massive = new double[lines, columns];

void FillingArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

FillingArrayRandomNumbers(Massive);
PrintArray(Massive);
