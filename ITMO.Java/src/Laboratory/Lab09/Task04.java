package Laboratory.Lab09;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Task04 {
    public static void main(String[] args) {
        Map<User, Integer> userMap = new LinkedHashMap<>();
        userMap.put(new User("Ivan"), 10);
        userMap.put(new User("Petr"), 5);
        userMap.put(new User("Alexey"), 9);

        System.out.println("Количество очков - " + getPoints(userMap));
    }

    public static Integer getPoints(Map<User, Integer> map) {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        for (var entry : map.keySet()) {
            if (entry.getName().equals(name)) {
                return map.get(entry);
            }
        }
        return null;
    }
}
