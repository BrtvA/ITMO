using Newtonsoft.Json;

namespace csharp.Dto
{
    internal class InputData<T>
        where T : struct
    {
        [JsonProperty("thread_count")]
        public int ThreadCount { get; set; }
        [JsonProperty("start_count")]
        public int StartCount { get; set; }
        [JsonProperty("trans_a")]
        public int TransA { get; set; }
        [JsonProperty("trans_b")]
        public int TransB { get; set; }
        [JsonProperty("alfa")]
        public T Alfa { get; set; }
        [JsonProperty("betta")]
        public T Betta { get; set; }
        [JsonProperty("matrix_a")]
        public List<List<T>> JsonMatrixA { get; set; }
        [JsonProperty("matrix_b")]
        public List<List<T>> JsonMatrixB { get; set; }


        [JsonIgnore]
        public T[,] MatrixA { get; private set; }
        [JsonIgnore]
        public T[,] MatrixB { get; private set; }

        public void ConvertToArray()
        {
            int rowA = JsonMatrixA.Count;
            int colA = JsonMatrixA[0].Count;
            T[,] arrA = new T[rowA, colA];
            for (int row = 0; row < rowA; row++)
            {
                for (int col = 0; col < colA; col++)
                {
                    arrA[row, col] = JsonMatrixA[row][col];
                }
            }

            int rowB = JsonMatrixB.Count;
            int colB = JsonMatrixA[0].Count;
            T[,] arrB = new T[rowB, colB];
            for (int row = 0; row < rowA; row++)
            {
                for (int col = 0; col < colA; col++)
                {
                    arrB[row, col] = JsonMatrixB[row][col];
                }
            }

            MatrixA = arrA;
            MatrixB = arrB;
        }
    }
}
