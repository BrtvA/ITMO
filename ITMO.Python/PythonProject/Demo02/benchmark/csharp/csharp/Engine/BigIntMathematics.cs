using System.Numerics;

namespace csharp.Engine
{
    internal class BigIntMathematics: Mathematics<BigInteger>
    {
        public BigIntMathematics() { }

        public override BigInteger[,] MultiplyMatricesParallel(BigInteger[,] matrixA, BigInteger[,] matrixB, int threadCount)
        {
            int rowA = matrixA.GetLength(0);
            int rowB = matrixB.GetLength(0);
            int colB = matrixB.GetLength(1);

            BigInteger[,] result = new BigInteger[rowA, colB];
            Parallel.For(0, rowA - 1, new ParallelOptions { MaxDegreeOfParallelism = threadCount }, row => {
                for (int col = 0; col < colB; col++)
                {
                    for (int idx = 0; idx < rowB; idx++)
                    {
                        result[row, col] = BigInteger.Add(result[row, col],
                                                          BigInteger.Multiply(matrixA[row, idx],
                                                                              matrixB[idx, col]));
                    }
                }
            });
            return result;
        }

        public override BigInteger[,] MultiplyMatrices(BigInteger[,] matrixA, BigInteger[,] matrixB)
        {
            int rowA = matrixA.GetLength(0);
            int rowB = matrixB.GetLength(0);
            int colB = matrixB.GetLength(1);

            BigInteger[,] result = new BigInteger[rowA, colB];
            for (int row = 0; row < rowA; row++)
            {
                for (int col = 0; col < colB; col++)
                {
                    for (int idx = 0; idx < rowB; idx++)
                    {
                        result[row, col] = BigInteger.Add(result[row, col],
                                                          BigInteger.Multiply(matrixA[row, idx],
                                                                              matrixB[idx, col]));
                    }
                }
            }
            return result;
        }

        public override BigInteger[,] AddMatrices(BigInteger[,] matrixA, BigInteger[,] matrixB)
        {
            int rowA = matrixA.GetLength(0);
            int colA = matrixA.GetLength(1);

            for (int row = 0; row < rowA; row++)
            {
                for (int col = 0; col < colA; col++)
                {
                    matrixA[row, col] = BigInteger.Add(matrixA[row, col], matrixB[row, col]);
                }
            }
            return matrixA;
        }

        public override BigInteger[,] MultiplyByScalar(BigInteger[,] matrix, BigInteger scalar)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    matrix[row, col] = BigInteger.Multiply(matrix[row, col], scalar);
                }
            }

            return matrix;
        }
    }
}
