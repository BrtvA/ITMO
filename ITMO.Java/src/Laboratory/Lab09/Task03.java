package Laboratory.Lab09;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Random;

public class Task03 {
    public static void main(String[] args) {
        List first = new ArrayList();
        List second = new LinkedList();

        System.out.println("ArrayList");
        addElements(first, 1000000, 10); // 31 мс
        getElements(first, 100000); // 17 мс

        System.out.println("LinkedList");
        addElements(second, 1000000, 10); // 196 мс
        getElements(second, 100000); // 124015 мс
    }

    public static void addElements(List list, Integer numberElements, Integer maxValue) {
        Random random = new Random();
        long timeBefore = System.currentTimeMillis();
        for (int i = 0; i < numberElements; i++) {
            list.add(random.nextInt(maxValue));
        }
        System.out.println("Время на добавление " + numberElements + " элементов - "
                            + (System.currentTimeMillis() - timeBefore) + " мс");
    }

    public static void getElements(List list, Integer number) {
        Random random = new Random();
        int count = list.size();
        long timeBefore = System.currentTimeMillis();
        for (int i = 0; i < number; i++) {
            list.get(random.nextInt(count));
        }
        System.out.println("Время на получение " + number + " элементов - "
                            + (System.currentTimeMillis() - timeBefore) + " мс");
    }


}
