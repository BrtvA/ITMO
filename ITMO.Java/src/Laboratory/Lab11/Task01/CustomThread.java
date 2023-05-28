package Laboratory.Lab11.Task01;

public class CustomThread extends Thread {
    private Integer minValue;
    private Integer maxValue;

    public CustomThread(String name, Integer minValue, Integer maxValue) {
        super(name);
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    @Override
    public void run() {
        String threadName = Thread.currentThread().getName();

        System.out.println(threadName + " " + Thread.currentThread().getState());

        for (int i = minValue; i <= maxValue; i++) {
            System.out.println(threadName + " " + i);
        }
    }
}
