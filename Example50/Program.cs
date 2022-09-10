// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillMatrixInt(int row, int col)
{
    Random random = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = random.Next(-99, 100);
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

void PrintByIndex(int[,] matrix, int rowPos, int colPos)
{
    if (rowPos <= matrix.GetLength(0)
        && colPos <= matrix.GetLength(1))
        {
            Console.WriteLine("Элемент с позицией ({0},{1}): {2}", rowPos, colPos, matrix[rowPos - 1, colPos - 1]);
        }
    else Console.WriteLine("Такого элемента не существует.");
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

    Console.Write("Введите через ',' позицию искомого элемента, начиная с 1: \t");
    int[] positions = Console.ReadLine().Split(",").Select(x => Convert.ToInt32(x)).ToArray();
    PrintByIndex(matrix, positions[0], positions[1]);
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}