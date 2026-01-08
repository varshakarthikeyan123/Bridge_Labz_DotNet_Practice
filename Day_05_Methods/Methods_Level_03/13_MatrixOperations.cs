using System;

class MatrixOperations
{
    static Random random = new Random();

    // a. Create random matrix
    static double[,] CreateMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = random.Next(1, 10);
        return matrix;
    }

    // i. Display matrix
    static void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // b. Add matrices
    static double[,] Add(double[,] a, double[,] b)
    {
        int r = a.GetLength(0), c = a.GetLength(1);
        double[,] result = new double[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }

    // c. Subtract matrices
    static double[,] Subtract(double[,] a, double[,] b)
    {
        int r = a.GetLength(0), c = a.GetLength(1);
        double[,] result = new double[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    // d. Multiply matrices
    static double[,] Multiply(double[,] a, double[,] b)
    {
        int r1 = a.GetLength(0), c1 = a.GetLength(1), c2 = b.GetLength(1);
        double[,] result = new double[r1, c2];

        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c2; j++)
                for (int k = 0; k < c1; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }

    // e. Transpose
    static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                result[j, i] = matrix[i, j];

        return result;
    }

    // f. Determinant of 2x2
    static double Determinant2x2(double[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    // g. Determinant of 3x3
    static double Determinant3x3(double[,] m)
    {
        return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
             - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
             + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
    }

    // h. Inverse of 2x2
    static double[,] Inverse2x2(double[,] m)
    {
        double det = Determinant2x2(m);
        if (det == 0) return null;

        return new double[,]
        {
            {  m[1,1]/det, -m[0,1]/det },
            { -m[1,0]/det,  m[0,0]/det }
        };
    }

    // h. Inverse of 3x3
    static double[,] Inverse3x3(double[,] m)
    {
        double det = Determinant3x3(m);
        if (det == 0) return null;

        double[,] inv = new double[3, 3];

        inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
        inv[0, 1] = -(m[0, 1] * m[2, 2] - m[0, 2] * m[2, 1]) / det;
        inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

        inv[1, 0] = -(m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) / det;
        inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
        inv[1, 2] = -(m[0, 0] * m[1, 2] - m[0, 2] * m[1, 0]) / det;

        inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
        inv[2, 1] = -(m[0, 0]()
