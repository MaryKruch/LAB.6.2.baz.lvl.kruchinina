namespace ClassLibrary1
{
    public class Matrix
    {
        public static string GetRowWithMaxSum(int[,] matrix)
        {
            int maxSum = 0;
            int maxSumRow = 0;



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[maxSumRow, maxSum])
                    {
                        maxSumRow = i;
                        maxSum = j;
                    }
                }
            }

            string vector = string.Empty;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                vector += matrix[maxSumRow, j] + " ";
            }
            return vector.Trim();
        }
    }
}