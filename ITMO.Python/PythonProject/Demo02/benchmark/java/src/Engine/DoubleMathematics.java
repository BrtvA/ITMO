package Engine;

import java.util.concurrent.CountDownLatch;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class DoubleMathematics implements IMathematics<Double> {
    @Override
    public Double[][] transposeMatrix(Double[][] matrix) {
        int rows = matrix.length;
        int columns = matrix[0].length;

        Double[][] transposedMatrix = new Double[columns][rows];
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++) {
                transposedMatrix[col][row] = matrix[row][col];
            }
        }

        return transposedMatrix;
    }

    @Override
    public Double[][] multiplyMatrices(Double[][] matrixA, Double[][] matrixB) {
        Double[][] result = new Double[matrixA.length][matrixB[0].length];
        for (int row = 0; row < matrixA.length; row++) {
            for (int col = 0; col < matrixB[0].length; col++) {
                for (int idx = 0; idx < matrixB.length; idx++) {
                    result[row][col] = result[row][col] == null ?
                            matrixA[row][idx] * matrixB[idx][col]
                            : result[row][col] + matrixA[row][idx] * matrixB[idx][col];
                }
            }
        }
        return result;
    }

    @Override
    public Double[][] multiplyMatricesParallel(Double[][] matrixA, Double[][] matrixB, int threadCount) {
        Double[][] result = new Double[matrixA.length][matrixB[0].length];

        ExecutorService executor = Executors.newFixedThreadPool(threadCount);
        CountDownLatch latch = new CountDownLatch(matrixA.length);
        for (int idx = 0; idx < matrixA.length; idx++) {
            int row = idx;
            executor.submit(new Runnable() {
                public void run() {
                    synchronized (result){
                        for (int col = 0; col < matrixB[0].length; col++) {
                            for (int idx = 0; idx < matrixB.length; idx++) {
                                result[row][col] = result[row][col] == null ?
                                        matrixA[row][idx] * matrixB[idx][col]
                                        : result[row][col] + matrixA[row][idx] * matrixB[idx][col];
                            }
                        }
                        latch.countDown();
                    }
                }
            });
        }
        try {
            latch.await();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        executor.shutdown();

        return result;
    }

    @Override
    public Double[][] addMatrices(Double[][] matrixA, Double[][] matrixB) {
        for (int row = 0; row < matrixA.length; row++) {
            for (int col = 0; col < matrixA[0].length; col++) {
                matrixA[row][col] = matrixA[row][col] + matrixB[row][col];
            }
        }
        return matrixA;
    }

    @Override
    public Double[][] multiplyByScalar(Double[][] matrix, Double scalar) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[0].length; col++) {
                matrix[row][col] = matrix[row][col] * scalar;
            }
        }
        return matrix;
    }
}
