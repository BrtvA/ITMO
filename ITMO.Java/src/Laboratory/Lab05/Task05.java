package Laboratory.Lab05;

public class Task05 {
    public static void main(String[] args) {
        String text = "This is a test string";

        System.out.print("The given string is: ");
        System.out.println(text);
        System.out.println("The string reversed word by word is:");
        System.out.println(invertWords(text));
    }

    private static String invertWords(String text) {
        StringBuilder builder = new StringBuilder();

        for (String word : text.split(" ")) {
            StringBuilder thisWord = new StringBuilder(word);
            builder.append(thisWord.reverse())
                    .append(" ");
        }

        return builder.toString().trim();
    }
}
