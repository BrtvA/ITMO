package Laboratory.Lab02.Task02;

public class Car {
    private String name;
    private String description;
    private Color color;
    private Integer price;
    private Integer maxSpeed;
    private Boolean isAutomaticTransmission;

    public Car() {

    }

    public Car(String name,
               String description,
               Color color,
               Integer price,
               Integer maxSpeed,
               Boolean isAutomaticTransmission) {

        this.name = name;
        this.description = description;
        this.color = color;
        this.price = price;
        this.maxSpeed = maxSpeed;
        this.isAutomaticTransmission = isAutomaticTransmission;

    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }


    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }


    public Color getColor() {
        return color;
    }

    public void setColor(Color color) {
        this.color = color;
    }


    public Integer getPrice() {
        return price;
    }

    public void setPrice(Integer price) {
        this.price = price;
    }


    public Integer getMaxSpeed() {
        return maxSpeed;
    }

    public void setMaxSpeed(Integer maxSpeed) {
        this.maxSpeed = maxSpeed;
    }


    public Boolean getIsAutomaticTransmission() {
        return isAutomaticTransmission;
    }

    public void setIsAutomaticTransmission(Boolean isAutomaticTransmission) {
        this.isAutomaticTransmission = isAutomaticTransmission;
    }


    public String toString() {
        return "Автомобиль: " + name + "\n"
                + "описание: " + description + "\n"
                + "цвет: " + color + "\n"
                + "цена: " + price + "\n"
                + "максимальная скорость: " + maxSpeed + "\n"
                + "наличие автоматической коробки передач: " + (isAutomaticTransmission ? "Да" : "Нет") + "\n";
    }

    public String getInfoDiscount(int percent) {
        double newPrice = price * (1 - (percent / 100.0));
        return "Новая цена автомобиля " + name + " " + description + " " + color + " " +
                "составляет " + newPrice + " рублей," + "\n" +
                "старая - " + price + " рублей" + "\n";
    }
}
