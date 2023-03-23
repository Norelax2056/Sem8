int line = 2;
int column = 2;
int numbers = 2;
int[,,] MatrixInit3D(int line, int column, int numbers, int min = 10, int max = 99)
{
    Random rnd = new Random();
    var matrix = new int[line, column, numbers];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int num = matrix.GetLength(2);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < num; k++)
            {
                Console.Write(matrix[i, j, k] + $"({i}, {j}, {k})" + "\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = MatrixInit3D(line, column, numbers);
Console.WriteLine($"\nCгенерированная матрица {line}x{column}x{numbers}:");
PrintMatrix3D(matrix);

