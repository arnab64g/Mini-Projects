namespace Matrix_Operation
{
    class Matrix_Multiply
    {
        public static void multiply(double[,] matA, double[,] matB, double[,] matR, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matR[i, j] = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        matR[i, j] += matA[i, k] * matB[k, j];
        }
        public static void addition(double[,] matA, double[,] matB, double[,] matR, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matR[i, j] = matA[i, j] + matB[i, j];
        }
        public static void substraction(double[,] matA, double[,] matB, double[,] matR, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matR[i, j] = matA[i, j] - matB[i, j];
        }
    }
}
