package Dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public class InputData<T> {
    @JsonProperty("thread_count")
    private int threadCount;
    @JsonProperty("start_count")
    private int startCount;
    @JsonProperty("trans_a")
    private int transA;
    @JsonProperty("trans_b")
    private int transB;
    @JsonProperty("alfa")
    private T alfa;
    @JsonProperty("betta")
    private T betta;
    @JsonProperty("matrix_a")
    private T[][] matrixA;
    @JsonProperty("matrix_b")
    private T[][] matrixB;

    public int getThreadCount() {
        return threadCount;
    }

    public int getStartCount() {
        return startCount;
    }

    public int getTransA() {
        return transA;
    }

    public int getTransB() {
        return transB;
    }

    public T getAlfa() {
        return alfa;
    }

    public T getBetta() {
        return betta;
    }

    public T[][] getMatrixA() {
        return matrixA;
    }

    public T[][] getMatrixB() {
        return matrixB;
    }
}
