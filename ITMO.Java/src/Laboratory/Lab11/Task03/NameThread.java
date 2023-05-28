package Laboratory.Lab11.Task03;

public class NameThread extends Thread {
    private String name;
    private Object obj;

    public NameThread(String name, Object obj) {
        this.name = name;
        this.obj = obj;
    }

    @Override
    public void run() {
        synchronized (obj) {
            while (true) {
                obj.notify();
                System.out.println(name);
                try {
                    obj.wait();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}
