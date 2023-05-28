package Laboratory.Lab07;

public class Plane {
    class Wing {
        private Integer weight;

        public Wing(Integer weight) {
            this.weight = weight;
        }

        public void printWeight() {
            System.out.println("Вес крыла составляет "
                                + weight + " кг");
        }
    }

    public void printInfo(Integer weight) {
        Wing wing = new Wing(weight);
        wing.printWeight();
    }

    public static void main(String[] args) {
        Plane planeFirst = new Plane();
        Plane planeSecond = new Plane();

        planeFirst.printInfo(1200);
        planeSecond.printInfo(3000);
    }
}
