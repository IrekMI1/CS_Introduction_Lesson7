// Задача HARD SORT. Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write("{0} \t", table[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

int[] SortArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

int[,] SortMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int n = 0;
    int[] array = new int[row * col];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[n] = matrix[i,j];
            n++;
        }
    }

    int[] sortedArray = SortArray(array);
    int m = 0;
   
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i,j] = sortedArray[m];
            m++;
        }
    }
    return matrix;
}

try
{
    Console.Write("Введите количество строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:\t");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = FillArray(m, n);
    Console.WriteLine($"Исходный массив размером {m} x {n}:");
    PrintArray(matrix);
    
    Console.WriteLine($"Сортированный массив размером {m} x {n}:");
    PrintArray(SortMatrix(matrix));
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}