package Laboratory.Lab09;

import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class Task02 {
    public static void main(String[] args) {
        List<String> unique = List.of("Petr", "Petr", "Ivan");

        System.out.println(unique);
        System.out.println(getUniqueList(unique));
    }

    public static Set getUniqueList(List unique) {
        return new HashSet<String>(unique);
    }
}
