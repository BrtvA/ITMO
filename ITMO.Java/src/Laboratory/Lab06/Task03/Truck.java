package Laboratory.Lab06.Task03;

public class Truck extends Car {
    private Integer wheelsCount;
    private Integer maxWeight;

    public Truck(int weight, String model, char color, float speed,
                 Integer wheelsCount, Integer maxWeight) {
        super(weight, model, color, speed);

        this.wheelsCount = wheelsCount;
        this.maxWeight = maxWeight;
    }

    public void newWheels(Integer wheelsCount) {
        this.wheelsCount = wheelsCount;
        System.out.println("Новое количество колес: " + this.wheelsCount);
    }

    public void printInfo() {
        super.outPut();
        System.out.println("Количество колес - " + wheelsCount
                            + ", максимальный вес - " + maxWeight + " кг");
    }
}
