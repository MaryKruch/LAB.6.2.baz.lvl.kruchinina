using ClassLibrary1;
using static ClassLibrary1.Matrix;
class Program
{
    static void Main()
    {
        Console.Write("Введите кол-во строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите кол-во столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Введите элемент [{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        string sumOfIndexes = Matrix.GetRowWithMaxSum(matrix);
        Console.WriteLine("Сумма индексов макс-ых элементов матрицы: {0}", sumOfIndexes);
    }
}