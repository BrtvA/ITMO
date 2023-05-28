namespace csharp.Engine
{
    internal class Benchmark<T, S>
        where T : struct
        where S : Mathematics<T>, new()
    {
        private T[,] _matrixA;
        private T[,] _matrixB;
        private int _transA;
        private int _transB;
        private T _alfa;
        private T _betta;
        private int _threadCount;
        private T[,] _result = null;
        public T[,] Result { get => _result; }
        public List<double> TimeInterval { get; private set; } = new List<double>();

        public Benchmark(T[,] matrixA, T[,] matrixB,
                         int transA, int transB,
                         T alfa, T betta, int threadCount)
        {
            _matrixA = matrixA;
            _matrixB = matrixB;
            _transA = transA;
            _transB = transB;
            _alfa = alfa;
            _betta = betta;
            _threadCount = threadCount;  
        }

        public void AddTimeInterval(double value)
        {
            TimeInterval.Add(value);
        }

        private T[,] TransposeMatrix(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            T[,] transposedMatrix = new T[columns, rows];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    transposedMatrix[col, row] = matrix[row, col];
                }
            }

            return transposedMatrix;
        }

        public void Dgemm()
        {
            lock (this)
            {
                if (_transA != 0)
                {
                    _matrixA = TransposeMatrix(_matrixA);
                }
                if (_transB != 0)
                {
                    _matrixA = TransposeMatrix(_matrixA);
                }

                Mathematics<T> mathematics = new S();

                T[,] multResult = _threadCount > 0 ? mathematics.MultiplyMatricesParallel(_matrixA, _matrixB, _threadCount)
                                                    : mathematics.MultiplyMatrices(_matrixA, _matrixB);
                T[,] expression = mathematics.MultiplyByScalar(multResult, _alfa);
                if (_result == null)
                {
                    _result = expression;
                }
                else
                {
                    _result = mathematics.AddMatrices(expression,
                                                     mathematics.MultiplyByScalar(_result, _betta));
                }
            }
        }
    }
}
