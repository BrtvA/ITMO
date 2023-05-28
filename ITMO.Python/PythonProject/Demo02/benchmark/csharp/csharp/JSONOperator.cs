using System.Text;
using csharp.Dto;
using Newtonsoft.Json;

namespace csharp
{
    internal class JSONOperator<T>
        where T : struct
    {
        private string _inputPath;

        public JSONOperator(string inputPath)
        {
            _inputPath = inputPath;
        }

        public async Task<InputData<T>> ReadJsonAsync()
        {
            InputData<T> inputData;
            if (File.Exists(_inputPath))
            {
                using (FileStream fs = new FileStream(_inputPath, FileMode.Open))
                {
                    byte[] buffer = new byte[fs.Length];
                    await fs.ReadAsync(buffer, 0, buffer.Length);
                    string textFromFile = Encoding.Default.GetString(buffer);
                    inputData = JsonConvert.DeserializeObject<InputData<T>>(textFromFile);

                }
                inputData.ConvertToArray();
            }
            else
            {
                inputData = null;
            }
            return inputData;
        }
    }
}
