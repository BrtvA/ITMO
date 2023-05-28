package Laboratory.Lab01;

import java.util.Scanner;

public class Task06 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int input = scanner.nextInt();
        if (input % 2 == 0) {
            if (input > 100) {
                System.out.println("Выход за пределы диапазона");
            } else {
                System.out.println("Четное");
            }
        } else {
            System.out.println("Нечетное");
        }
    }
}