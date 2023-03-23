Console.WriteLine("Введите количество столбцов: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int maxElement = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ",");
            else Console.Write(arr[i, j] + "]");

        }
        Console.WriteLine();
    }
}

void SelectionSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = arr.GetLength(1) - 1; j > 0; j--)
        {

            for (int k = 1; k <= j; k++)
            {
                if (arr[i, k] > arr[i, k - 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k - 1];
                    arr[i, k - 1] = temp;
                }
            }

        }

    }
    Console.WriteLine();

}
int[,] matrix = CreateMatrix(num1, num2, minElement, maxElement);
PrintMatrix(matrix);
Console.WriteLine();
SelectionSort(matrix);
PrintMatrix(matrix);

