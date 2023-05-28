package Engine;

public interface IMathematics<T> {
    public abstract T[][] transposeMatrix(T[][] matrix);

    public abstract T[][] multiplyMatrices(T[][] matrixA, T[][] matrixB);

    public abstract T[][] multiplyMatricesParallel(T[][] matrixA, T[][] matrixB, int threadCount);

    public abstract T[][] addMatrices(T[][] matrixA, T[][] matrixB);

    public abstract T[][] multiplyByScalar(T[][] matrix, T scalar);
}
