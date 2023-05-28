package Laboratory.Lab06.Task03;

public class Main {
    public static void main(String[] args) {
        Truck man = new Truck(8000, "MAN TGM", 'b', 80f, 6, 12000);

        man.printInfo();
        man.newWheels(8);
    }
}
