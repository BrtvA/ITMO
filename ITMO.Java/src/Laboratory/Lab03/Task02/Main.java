package Laboratory.Lab03.Task02;

public class Main {
    public static void main(String[] args) {
        Car porsche = new Car(Color.BLACK);
        porsche.setName("Porsche");
        porsche.setWeight(3);

        Car mazda = new Car(Color.RED, 2);
        mazda.setName("Mazda");

        porsche.printInfo();
        mazda.printInfo();
    }
}
