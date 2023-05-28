using csharp;

Console.WriteLine("[C#] Введите путь к входному файлу => ");
var inputString = Console.ReadLine().Split();
string inputPath = inputString[0];
string dataType = inputString[1];
Console.WriteLine($"[C#] Путь к входному файлу: {inputPath}");

Starter starter = new Starter(inputPath, dataType);
Console.WriteLine($"[C#] {await starter.StartBenchmark()}");