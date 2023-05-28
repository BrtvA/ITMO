package Laboratory.Lab05;

public class Task03 {
    public static void main(String[] args) {
        String text = "Слово бяка - это что-то плохое";
        String modifiedWord = "бяка";
        String replacement = "[вырезано цензурой]";

        System.out.println(text);
        System.out.println(replaceWord(text, modifiedWord, replacement));
    }

    private static String replaceWord(String text, String modifiedWord, String replacement) {
        return text.replaceAll(modifiedWord, replacement);
    }
}
