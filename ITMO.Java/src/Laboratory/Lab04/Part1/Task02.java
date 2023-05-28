package Laboratory.Lab04.Part1;

public class Task02 {
    public static void main(String[] args) {
        showNumbers();
    }

    private static void showNumbers() {
        String div3 = "Делится на 3:";
        String div5 = "Делится на 5:";
        String div35 = "Делится на 3 и 5:";

        for (int i = 1; i < 100; i++) {
            if (i % 3 == 0) {
                div3 += " " + i;
            }

            if (i % 5 == 0) {
                div5 += " " + i;
            }

            if (i % 3 == 0 && i % 5 == 0) {
                div35 += " " + i;
            }
        }

        System.out.println(div3);
        System.out.println(div5);
        System.out.println(div35);
    }
}
