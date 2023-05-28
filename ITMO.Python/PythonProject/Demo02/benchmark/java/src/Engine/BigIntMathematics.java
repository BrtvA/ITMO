package Engine;

import java.math.BigInteger;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class BigIntMathematics implements IMathematics<BigInteger> {

    @Override
    public BigInteger[][] transposeMatrix(BigInteger[][] matrix) {
        int rows = matrix.length;
        int columns = matrix[0].length;

        BigInteger[][] transposedMatrix = new BigInteger[columns][rows];
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++) {
                transposedMatrix[col][row] = matrix[row][col];
            }
        }

        return transposedMatrix;
    }

    @Override
    public BigInteger[][] multiplyMatrices(BigInteger[][] matrixA, BigInteger[][] matrixB) {
        BigInteger[][] result = new BigInteger[matrixA.length][matrixB[0].length];
        for (int row = 0; row < matrixA.length; row++) {
            for (int col = 0; col < matrixB[0].length; col++) {
                for (int idx = 0; idx < matrixB.length; idx++) {
                    result[row][col] = result[row][col] == null ?
                            matrixA[row][idx].multiply(matrixB[idx][col])
                            : result[row][col].add(matrixA[row][idx].multiply(matrixB[idx][col]));
                }
            }
        }
        return result;
    }

    @Override
    public BigInteger[][] multiplyMatricesParallel(BigInteger[][] matrixA, BigInteger[][] matrixB, int threadCount) {
        BigInteger[][] result = new BigInteger[matrixA.length][matrixB[0].length];

        ExecutorService executor = Executors.newFixedThreadPool(threadCount);
        CountDownLatch latch = new CountDownLatch(matrixA.length);
        for (int idx = 0; idx < matrixA.length; idx++) {
            int row = idx;
            executor.submit(new Runnable() {
                public void run() {
                    synchronized (result) {
                        for (int col = 0; col < matrixB[0].length; col++) {
                            for (int idx = 0; idx < matrixB.length; idx++) {
                                result[row][col] = result[row][col] == null ?
                                        matrixA[row][idx].multiply(matrixB[idx][col])
                                        : result[row][col].add(matrixA[row][idx].multiply(matrixB[idx][col]));
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
    public BigInteger[][] addMatrices(BigInteger[][] matrixA, BigInteger[][] matrixB) {

        for (int row = 0; row < matrixA.length; row++) {
            for (int col = 0; col < matrixA[0].length; col++) {
                matrixA[row][col] = matrixA[row][col].add(matrixB[row][col]);
            }
        }
        return matrixA;
    }

    @Override
    public BigInteger[][] multiplyByScalar(BigInteger[][] matrix, BigInteger scalar) {

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[0].length; col++) {
                matrix[row][col] = matrix[row][col].multiply(scalar);
            }
        }
        return matrix;
    }
}
