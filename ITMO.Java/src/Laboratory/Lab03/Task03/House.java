package Laboratory.Lab03.Task03;

import java.time.LocalDate;

public class House {
    private Integer floorNumber;
    private Integer yearСonstruction;
    private String name;

    public void setInfo(Integer floorNumber,
                        Integer yearСonstruction,
                        String name) {
        this.floorNumber = floorNumber;
        this.yearСonstruction = yearСonstruction;
        this.name = name;
    }

    public void printInfo() {
        System.out.println(name + " "
                            + yearСonstruction + " года постройки"
                            + " имеет " + floorNumber + " этажей.");
    }

    public Integer getYearCount() {
        return LocalDate.now().getYear() - yearСonstruction;
    }
}
