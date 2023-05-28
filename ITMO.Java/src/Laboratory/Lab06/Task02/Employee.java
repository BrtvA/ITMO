package Laboratory.Lab06.Task02;

public class Employee implements Human {
    private String firstName;
    private String lastName;
    private String bankName;

    public Employee(String firstName, String lastName, String bankName) {
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
        return lastName;
    }

    @Override
    public void printInfo() {
        System.out.println(getFirstName() + " " + getLastName()
                            + " работает в " + bankName);
    }
}
