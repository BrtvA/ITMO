package Laboratory.Lab06.Task01;

public class Main {
    public static void main(String[] args) {
        Human petr = new Client("Пётр", "Петров", "Сбербанк");
        Human ivan = new Employee("Иван", "Иванов", "ВТБ");

        printInfo(petr);
        printInfo(ivan);
    }

    public static void printInfo(Human human) {
        human.printInfo();
    }
}
