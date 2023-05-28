package Laboratory.Lab11.Task03;

public class Main {
    public static void main(String[] args) {
        startThread("Ivan", "Petr");
    }

    public static void startThread(String first, String second) {
        Object obj = new Object();

        NameThread thread1 = new NameThread(first, obj);
        NameThread thread2 = new NameThread(second, obj);

        thread1.start();
        thread2.start();
    }
}
