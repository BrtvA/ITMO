namespace csharp.Engine
{
    internal class IntMathematics: Mathematics<int>
    {
        public IntMathematics() { }

        public override int[,] MultiplyMatricesParallel(int[,] matrixA, int[,] matrixB, int threadCount)
        {
            int rowA = matrixA.GetLength(0);
            int rowB = matrixB.GetLength(0);
            int colB = matrixB.GetLength(1);

            int[,] result = new int[rowA, colB];
            Parallel.For(0, rowA-1, new ParallelOptions { MaxDegreeOfParallelism = threadCount }, row => {
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

        public override int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowA = matrixA.GetLength(0);
            int rowB = matrixB.GetLength(0);
            int colB = matrixB.GetLength(1);

            int[,] result = new int[rowA, colB];
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

        public override int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
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

        public override int[,] MultiplyByScalar(int[,] matrix, int scalar)
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
