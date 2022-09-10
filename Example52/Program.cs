// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillMatrixInt(int row, int col)
{
    Random random = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = random.Next(20);
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} \t", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintColumnAverage(int[,] matrix)
{
    double sum = 0;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Console.WriteLine("Среднее арифметическое в каждом столбце:");
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        Console.Write("{0}; \t", Math.Round(sum / rows, 2));
        sum = 0;
    }
}

try
{
    Console.Write("Введите число строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов:\t");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = FillMatrixInt(m, n);
    Console.WriteLine("Сгенерированный массив {0}x{1}:", m, n);
    PrintMatrixInt(matrix);
    PrintColumnAverage(matrix);
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}