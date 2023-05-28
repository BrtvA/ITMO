package Engine;

import Dto.InputData;

public class Benchmark<T> {
    private int threadCount;
    private int transA;
    private int transB;
    private T alfa;
    private T betta;
    private T[][] matrixA;
    private T[][] matrixB;
    private T[][] result = null;
    private double[] timeInterval;

    private Class<T> cls;

    public Benchmark(InputData<T> inputData,
                     Class<T> cls) {
        this.threadCount = inputData.getThreadCount();
        this.matrixA = inputData.getMatrixA();
        this.matrixB = inputData.getMatrixB();
        this.transA = inputData.getTransA();
        this.transB = inputData.getTransB();
        this.alfa = inputData.getAlfa();
        this.betta = inputData.getBetta();
        timeInterval = new double[inputData.getStartCount()];
        this.cls = cls;
    }

    public T[][] getResult() {
        return result;
    }

    public double[] getTimeInterval() {
        return timeInterval;
    }

    public void setValueTimeInterval(int idx, double value) {
        synchronized (this) {
            timeInterval[idx] = value;
        }
    }

    public void dgemm() {
        synchronized (this) {
            MathematicsFactory<T> mathematicsFactory = new MathematicsFactory<>(cls);
            IMathematics<T> IMathematics = mathematicsFactory.get();

            if (transA != 0) {
                matrixA = IMathematics.transposeMatrix(matrixA);
            }
            if (transB != 0) {
                matrixB = IMathematics.transposeMatrix(matrixB);
            }

            T[][] multResult = threadCount > 0 ? IMathematics.multiplyMatricesParallel(matrixA, matrixB, threadCount)
                    : IMathematics.multiplyMatrices(matrixA, matrixB);
            T[][] expression = IMathematics.multiplyByScalar(multResult, alfa);
            if (result == null) {
                result = expression;
            } else {
                result = IMathematics.addMatrices(expression,
                        IMathematics.multiplyByScalar(result, betta));
            }
        }
    }
}
