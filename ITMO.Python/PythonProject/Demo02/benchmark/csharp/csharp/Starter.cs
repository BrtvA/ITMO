using System.Numerics;
using csharp.Dto;
using csharp.Engine;

namespace csharp
{
    internal class Starter
    {
        private const string TYPE_INT = "Integer";
        private const string TYPE_DOUBLE = "Double";
        private const string TYPE_BIG_INTEGER = "BigInteger";

        private string _inputPath;
        private string _dataType;

        public Starter(string inputPath, string dataType)
        {
            _inputPath= inputPath;
            _dataType = dataType;
        }

        public async Task<double> StartBenchmark()
        {
            switch (_dataType)
            {
                case TYPE_INT:
                    return await StartIntBench();
                case TYPE_DOUBLE:
                    return await StartDoubleBench();
                case TYPE_BIG_INTEGER:
                    return await StartBigIntBench();
                default:
                    Console.WriteLine("Неверный тип данных");
                    return -999;
            }
        }

        private async Task<double> StartBigIntBench()
        {
            JSONOperator<BigInteger> json = new JSONOperator<BigInteger>(_inputPath);
            InputData<BigInteger> inputData = await json.ReadJsonAsync();

            if (inputData is null)
            {
                Console.WriteLine($"[C#] Файл по пути {_inputPath} не найден");
                return -999;
            }

            int startCount = inputData.StartCount;

            Benchmark<BigInteger, BigIntMathematics> benchmark = new Benchmark<BigInteger, BigIntMathematics>(
                        inputData.MatrixA, inputData.MatrixB,
                        inputData.TransA, inputData.TransB,
                        inputData.Alfa, inputData.Betta, inputData.ThreadCount);

            for (int idx = 0; idx < startCount; idx++)
            {
                var time = new System.Diagnostics.Stopwatch();
                time.Start();
                benchmark.Dgemm();
                time.Stop();
                benchmark.AddTimeInterval((double)time.ElapsedMilliseconds);
            }
            return benchmark.TimeInterval.Sum();
        }

        private async Task<double> StartIntBench()
        {
            JSONOperator<int> json = new JSONOperator<int>(_inputPath);
            InputData<int> inputData = await json.ReadJsonAsync();

            if (inputData is null)
            {
                Console.WriteLine($"[C#] Файл по пути {_inputPath} не найден");
                return -999;
            }

            int startCount = inputData.StartCount;

            Benchmark<int, IntMathematics> benchmark = new Benchmark<int, IntMathematics>(
                        inputData.MatrixA, inputData.MatrixB,
                        inputData.TransA, inputData.TransB,
                        inputData.Alfa, inputData.Betta, inputData.ThreadCount);

            for (int idx = 0; idx < startCount; idx++)
            {
                var time = new System.Diagnostics.Stopwatch();
                time.Start();
                benchmark.Dgemm();
                time.Stop();
                benchmark.AddTimeInterval((double)time.ElapsedMilliseconds);
            }
            return benchmark.TimeInterval.Sum();
        }

        private async Task<double> StartDoubleBench()
        {
            JSONOperator<double> json = new JSONOperator<double>(_inputPath);
            InputData<double> inputData = await json.ReadJsonAsync();

            if (inputData is null)
            {
                Console.WriteLine($"[C#] Файл по пути {_inputPath} не найден");
                return -999;
            }

            int startCount = (int)inputData.StartCount;

            Benchmark<double, DoubleMathematics> benchmark = new Benchmark<double, DoubleMathematics>(
                        inputData.MatrixA, inputData.MatrixB,
                        inputData.TransA, inputData.TransB,
                        inputData.Alfa, inputData.Betta, inputData.ThreadCount);

            for (int idx = 0; idx < startCount; idx++)
            {
                var time = new System.Diagnostics.Stopwatch();
                time.Start();
                benchmark.Dgemm();
                time.Stop();
                benchmark.AddTimeInterval((double)time.ElapsedMilliseconds);
            }
            return benchmark.TimeInterval.Sum();
        }
    }
}
