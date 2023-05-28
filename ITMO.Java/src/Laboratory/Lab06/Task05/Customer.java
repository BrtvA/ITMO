package Laboratory.Lab06.Task05;

public class Customer extends User {
    @Override
    public void getInfo() {
        System.out.println("Имя " + getScanner().nextLine());
    }
}