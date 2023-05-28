package Laboratory.Lab11.Task02;

public class Counter {
    int count = 0;

    public void increment() {
        synchronized (this) {
            count = count + 1;
        }
    }

    public int getCount() {
        return count;
    }
}
