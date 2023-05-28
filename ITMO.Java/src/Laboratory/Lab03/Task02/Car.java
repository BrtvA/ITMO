package Laboratory.Lab03.Task02;

public class Car {
    private Color color;
    private String name;
    private Integer weight;

    public Car(Color color) {
        this.color = color;
    }

    public Car(Color color, Integer weight) {
        this.weight = weight;
        this.color = color;
    }

    public Car() {

    }


    public Color getColor() {
        return color;
    }

    public void setColor(Color color) {
        this.color = color;
    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }


    public Integer getWeight() {
        return weight;
    }

    public void setWeight(Integer weight) {
        this.weight = weight;
    }

    public void printInfo() {
        System.out.println("Автомобиль " + name
                            + " " + color
                            + " весит " + weight + " т.");
    }
}
