namespace csharp.Engine
{
    internal abstract class Mathematics<T>
    {
        public abstract T[,] MultiplyMatrices(T[,] matrixA, T[,] matrixB);
        public abstract T[,] MultiplyMatricesParallel(T[,] matrixA, T[,] matrixB, int threadCount);

        public abstract T[,] AddMatrices(T[,] matrixA, T[,] matrixB);

        public abstract T[,] MultiplyByScalar(T[,] matrix, T scalar);
    }
}
