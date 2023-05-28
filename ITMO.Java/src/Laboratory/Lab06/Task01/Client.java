package Laboratory.Lab06.Task01;

public class Client extends Human {
    private String bankName;

    public Client(String firstName, String lastName, String bankName) {
        super(firstName, lastName);
        this.bankName = bankName;
    }

    @Override
    public void printInfo() {
        System.out.println(getFirstName() + " " + getLastName()
                + " является клиентом " + bankName);
    }
}
