import Dto.InputData;
import Engine.Benchmark;
import com.fasterxml.jackson.core.JsonProcessingException;

import java.math.BigInteger;
import java.util.Arrays;

public class Starter {
    private final String TYPE_INTEGER = "Integer";
    private final String TYPE_DOUBLE = "Double";
    private final String TYPE_BIG_INTEGER = "BigInteger";

    private String inputPath;
    private String dataType;

    public Starter(String inputPath, String dataType) {
        this.inputPath = inputPath;
        this.dataType = dataType;
    }

    public double startBenchmark() {
        try {
            switch (dataType) {
                case (TYPE_INTEGER):
                    return startIntBench();
                case (TYPE_DOUBLE):
                    return startDoubleBench();
                case (TYPE_BIG_INTEGER):
                    return startBigIntBench();
                default:
                    System.out.println("[Java] Неверный тип данных");
                    return -999;
            }
        } catch (IllegalStateException e) {
            e.printStackTrace();
            return -999;
        } catch (JsonProcessingException e) {
            e.printStackTrace();
            return -999;
        } catch (NullPointerException e) {
            e.printStackTrace();
            System.out.println(e.getMessage());
            return -999;
        }
    }

    private double startBigIntBench() throws IllegalStateException, JsonProcessingException, NullPointerException {
        JSONOperator<BigInteger> json = new JSONOperator(inputPath, BigInteger.class);
        InputData<BigInteger> inputData = json.readJSON();

        Benchmark<BigInteger> benchmark = new Benchmark(inputData, BigInteger.class);

        for (int idx = 0; idx < inputData.getStartCount(); idx++) {
            long startTime = System.nanoTime();
            benchmark.dgemm();
            benchmark.setValueTimeInterval(idx,
                    ((double) System.nanoTime() - (double) startTime) / Math.pow(10, 6));
        }

        return Arrays.stream(benchmark.getTimeInterval()).sum();
    }

    private double startIntBench() throws IllegalStateException, JsonProcessingException, NullPointerException {
        JSONOperator<Integer> json = new JSONOperator(inputPath, Integer.class);
        InputData<Integer> inputData = json.readJSON();

        Benchmark<Integer> benchmark = new Benchmark(inputData, Integer.class);

        for (int idx = 0; idx < inputData.getStartCount(); idx++) {
            long startTime = System.nanoTime();
            benchmark.dgemm();
            benchmark.setValueTimeInterval(idx,
                    ((double) System.nanoTime() - (double) startTime) / Math.pow(10, 6));
        }

        return Arrays.stream(benchmark.getTimeInterval()).sum();
    }

    private double startDoubleBench() throws IllegalStateException, JsonProcessingException, NullPointerException {
        JSONOperator<Double> json = new JSONOperator(inputPath, Double.class);
        InputData<Double> inputData = json.readJSON();

        Benchmark<Double> benchmark = new Benchmark(inputData, Double.class);

        for (int idx = 0; idx < inputData.getStartCount(); idx++) {
            long startTime = System.nanoTime();
            benchmark.dgemm();
            benchmark.setValueTimeInterval(idx,
                    ((double) System.nanoTime() - (double) startTime) / Math.pow(10, 6));
        }

        return Arrays.stream(benchmark.getTimeInterval()).sum();
    }
}
