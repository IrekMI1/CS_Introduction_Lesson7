// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillMatrixDouble(int row, int col)
{
    Random random = new Random();
    double[,] matrix = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = random.Next(-99, 100) + random.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} \t", Math.Round(matrix[i, j], 2));
        }
        Console.WriteLine();
    }
}

try
{
    Console.Write("Введите число строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов:\t");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = FillMatrixDouble(m, n);
    PrintMatrixDouble(matrix);
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}
