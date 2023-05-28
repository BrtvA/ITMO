package Laboratory.Lab10;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        String inputPath = "src/Laboratory/Lab10/input.txt";
        System.out.println(readAsList(inputPath));

        String outputPath = "src/Laboratory/Lab10/output.txt";
        writeText("Буферизованные считыватели предпочтительнее для более сложных задач",
                outputPath);

        readAndWrite(inputPath, outputPath);

        readСhangeWrite(outputPath);
    }

    public static List<String> readAsList(String path) {
        List<String> stringList = new ArrayList<>();

        try (BufferedReader reader = new BufferedReader(
                new FileReader(path))) {
            String line;
            while ((line = reader.readLine()) != null) {
                stringList.add(line);
            }
        } catch (IOException ex) {
            System.err.println("Error: " + ex.getMessage());
        }

        return stringList;
    }

    public static void writeText(String line, String path) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(path))) {
            writer.write(line);
        } catch (IOException ex) {
            System.err.println(ex.getMessage());
        }
    }

    public static void readAndWrite(String inputPath, String outputPath) {
        List<String> stringList = readAsList(inputPath);
        StringBuilder builder = new StringBuilder();

        for (String line : stringList) {
            builder.append(line).append(" ");
        }

        writeText(builder.toString().trim(), outputPath);
    }

    public static void readСhangeWrite(String path) {
        List<String> stringList = readAsList(path);
        StringBuilder builder = new StringBuilder();
        String newLine;

        for (String line : stringList) {
            newLine = line.replaceAll("[^а-яА-Яa-zA-Z0-9]",
                                      "\\$");
            builder.append(newLine).append(" ");
        }

        writeText(builder.toString().trim(), path);
    }
}
