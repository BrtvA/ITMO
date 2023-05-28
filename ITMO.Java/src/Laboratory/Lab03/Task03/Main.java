package Laboratory.Lab03.Task03;

public class Main {
    public static void main(String[] args) {
        House cottage = new House();
        cottage.setInfo(3, 2000, "Коттедж");

        House countryHouse = new House();
        countryHouse.setInfo(1, 1990, "Дача");

        cottage.printInfo();
        System.out.println("С момента постройки прошло " + cottage.getYearCount() + " лет\n");
        countryHouse.printInfo();
        System.out.println("С момента постройки прошло " + countryHouse.getYearCount() + " лет\n");
    }
}
