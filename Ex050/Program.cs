// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int m = 3;
int n = 4;
int[,] matrix = FillMatrix(m, n, -10, 10);
PrintMatrix(matrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        } 
        Console.WriteLine();   
    }
}

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }   
    return matrix;     
}

Console.Write("Введите позицию элемента в строке: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else 
{
    Console.WriteLine($"Значение элемента -> {matrix[a, b]}");
}
   

      
     