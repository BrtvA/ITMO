import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("[Java] Введите путь к входному файлу => ");
        String[] inputString = scanner.nextLine().split(" ");
        scanner.close();

        String inputPath = inputString[0];
        String dataType = inputString[1];

        System.out.println("[Java] Путь к входному файлу: " + inputPath);
        Starter starter = new Starter(inputPath, dataType);
        System.out.println("[Java] " + starter.startBenchmark());

//        PrintStream printStream = new PrintStream(System.out, true, "utf-8");
//        printStream.println(stringPath);
    }
}
