package Laboratory.Lab06.Task04;

import java.util.Scanner;

public class Parent {
    private Integer number;

    public Parent() {
        Scanner scanner = new Scanner(System.in);
        number = scanner.nextInt();
    }

    public Integer getNumber() {
        return number;
    }
}