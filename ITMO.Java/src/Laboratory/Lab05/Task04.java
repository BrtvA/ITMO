package Laboratory.Lab05;

public class Task04 {
    public static void main(String[] args) {
        String line = "BAAVVVBCAABAA";
        String subline = "AA";

        System.out.println("Количество вхождений: " + getOverlapCount(line, subline));
    }

    private static int getOverlapCount(String line, String subline) {
        return line.split(subline, -1).length - 1;
    }
}
