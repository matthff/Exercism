public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size, size];
        return DrawMatrix(matrix, size, 0, 0, 1);
    }

    private static int[,] DrawMatrix(int[,] matrix, int size, int row, int col, int value)
    {
        if (size < 1)
            return matrix;

        matrix[row, col] = value++;

        if (size < 2)
            return matrix;

        for (int i = 0; i < size - 1; i++)
            matrix[row, ++col] = value++;

        for (int i = 0; i < size - 1; i++)
            matrix[++row, col] = value++;

        for (int i = 0; i < size - 1; i++)
            matrix[row, --col] = value++;

        for (int i = 0; i < size - 2; i++)
            matrix[--row, col] = value++;

        return DrawMatrix(matrix, size - 2, row, col + 1, value);
    }
}
