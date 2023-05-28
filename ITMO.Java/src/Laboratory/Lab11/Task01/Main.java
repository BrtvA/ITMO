package Laboratory.Lab11.Task01;

public class Main {
    public static void main(String[] args) {
        startThread(10, 0, 10);
    }

    public static void startThread(Integer threadCount, Integer minValue, Integer maxValue) {
        for (int i = 0; i < threadCount; i++) {
            CustomThread thread = new CustomThread("Thread" + i, minValue, maxValue);
            System.out.println(thread.getName() + " " + thread.getState());
            thread.start();
            try{
                thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            System.out.println(thread.getName() + " " + thread.getState());
        }
    }
}
