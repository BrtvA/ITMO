package Laboratory.Lab04.Part1;

public class Task03 {
    public static void main(String[] args) {
        int number1 = 5;
        int number2 = 10;
        int number3 = 15;

        System.out.println("Введите первое число: " + number1);
        System.out.println("Введите второе число: " + number2);
        System.out.println("Введите третье число: " + number3);
        System.out.println("Результат: " + сompareNumbers(number1, number2, number3));
    }

    private static boolean сompareNumbers(int number1,
                                          int number2,
                                          int number3) {
        return (number1 + number2) == number3;
    }
}
