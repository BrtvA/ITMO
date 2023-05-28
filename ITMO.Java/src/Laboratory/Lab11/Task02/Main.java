package Laboratory.Lab11.Task02;

public class Main {
    public static void main(String[] args) {
        Counter counter = new Counter();
        startThread(counter, 100, 1000);
        System.out.println(counter.getCount());
    }

    public static void startThread(Counter counter, Integer threadCount, Integer count) {
        Thread[] threads = new Thread[threadCount];

        for (int i = 0; i < threadCount; i++) {
            threads[i] = new Thread(() -> {
                synchronized (counter) {
                    for (int j = 0; j < count; j++) {
                        counter.increment();
                    }

                    try {
                        counter.wait();
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            });
            threads[i].start();
        }

        boolean isContinue = true;
        while (isContinue) {
            boolean isStop = false;
            for (int j = 0; j < threadCount; j++) {
                boolean isWaiting = threads[j].getState() == Thread.State.WAITING;
                if (j == 0) {
                    isStop = isWaiting;
                } else {
                    isStop = isStop && isWaiting;
                }
            }
            isContinue = isContinue && !isStop;
        }

        synchronized (counter) {
            counter.notifyAll();
        }
    }
}
