package Laboratory.Lab02.Task01;

public class Main {
    public static void main(String[] args) {
        Calculator calc = new Calculator();

        System.out.println("Сумма");
        System.out.println(calc.summation(2, 3));
        System.out.println(calc.summation(2L, 3L));
        System.out.println(calc.summation(2d, 3d));

        System.out.println("Вычитание");
        System.out.println(calc.subtraction(2, 3));
        System.out.println(calc.subtraction(2L, 3L));
        System.out.println(calc.subtraction(2d, 3d));

        System.out.println("Деление");
        System.out.println(calc.division(5, 2));
        System.out.println(calc.division(5L, 2L));
        System.out.println(calc.division(5d, 2d));

        System.out.println("Умножение");
        System.out.println(calc.multiplication(5, 2));
        System.out.println(calc.multiplication(5L, 2L));
        System.out.println(calc.multiplication(5d, 2d));
    }
}
