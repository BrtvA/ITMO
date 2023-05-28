package Laboratory.Lab06.Task02;

public class Client implements Human {
    private String firstName;
    private String lastName;
    private String bankName;

    public Client(String firstName, String lastName, String bankName) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.bankName = bankName;
    }

    @Override
    public String getFirstName() {
        return firstName;
    }

    @Override
    public String getLastName() {
        return firstName;
    }

    @Override
    public void printInfo() {
        System.out.println(getFirstName() + " " + getLastName()
                            + " является клиентом " + bankName);
    }
}
