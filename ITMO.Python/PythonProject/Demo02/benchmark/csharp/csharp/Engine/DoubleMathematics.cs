namespace csharp.Engine
{
    internal class DoubleMathematics: Mathematics<double>
    {
        public DoubleMathematics() { }

        public override double[,] MultiplyMatricesParallel(double[,] matrixA, double[,] matrixB, int threadCount)
        {
            int rowA = matrixA.GetLength(0);
            int rowB = matrixB.GetLength(0);
            int colB = matrixB.GetLength(1);

            double[,] result = new double[rowA, colB];
            Parallel.For(0, rowA - 1, new ParallelOptions { MaxDegreeOfParallelism = threadCount }, row => {
                for (int col = 0; col < colB; col++)
                {
                    for (int idx = 0; idx < rowB; idx++)
                    {
                        result[row, col] += matrixA[row, idx] * matrixB[idx, col];
                    }
                }
            });
            return result;
        }

        public override double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
        {
            int rowA = matrixA.GetLength(0);
            int rowB = matrixB.GetLength(0);
            int colB = matrixB.GetLength(1);

            double[,] result = new double[rowA, colB];
            for (int row = 0; row < rowA; row++)
            {
                for (int col = 0; col < colB; col++)
                {
                    for (int idx = 0; idx < rowB; idx++)
                    {
                        result[row, col] += matrixA[row, idx] * matrixB[idx, col];
                    }
                }
            }
            return result;
        }

        public override double[,] AddMatrices(double[,] matrixA, double[,] matrixB)
        {
            int rowA = matrixA.GetLength(0);
            int colA = matrixA.GetLength(1);

            for (int row = 0; row < rowA; row++)
            {
                for (int col = 0; col < colA; col++)
                {
                    matrixA[row, col] += matrixB[row, col];
                }
            }
            return matrixA;
        }

        public override double[,] MultiplyByScalar(double[,] matrix, double scalar)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    matrix[row, col] *= scalar;
                }
            }
            return matrix;
        }
    }
}
