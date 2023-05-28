package Laboratory.Lab04.Part1;

public class Task01 {
    public static void main(String[] args) {
        showOddNumbers();
    }

    private static void showOddNumbers() {
        for (int i = 1; i < 100; i++) {
            if (i % 2 != 0) {
                System.out.println(i);
            }
        }
    }
}
