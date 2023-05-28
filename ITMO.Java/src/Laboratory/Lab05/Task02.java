package Laboratory.Lab05;

import java.util.Locale;

public class Task02 {
    public static void main(String[] args) {
        String word = "Довод";

        System.out.println("Слово \'" + word + "\' "
                            + (isPalindrome(word) ? "является" : "не является")
                            + " палиндромом");
    }

    public static boolean isPalindrome(String word) {
        word = word.toLowerCase();
        StringBuilder builder = new StringBuilder(word);

        return word.equals(builder.reverse().toString());
    }
}
