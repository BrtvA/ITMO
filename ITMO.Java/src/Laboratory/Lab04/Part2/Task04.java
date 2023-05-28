package Laboratory.Lab04.Part2;

import java.util.Arrays;

public class Task04 {
    public static void main(String[] args) {
        int[] arr = {1, 2, 3, 1, 2, 4};

        System.out.println(Arrays.toString(arr));
        System.out.println("Первое уникальное число: "
                            + findFirstUniqueNumber(arr));
    }

    private static int findFirstUniqueNumber(int[] arr) {
        int[] sortedArray = bubbleSort(arr);

        int nonUnique = sortedArray[0];
        for (int i = 1; i < sortedArray.length; i++) {
            if (sortedArray[i] == nonUnique) {
                nonUnique = sortedArray[i];
            } else {
                if (i == (sortedArray.length - 1)) {
                    return sortedArray[i];
                }

                if (sortedArray[i] != sortedArray[i + 1]) {
                    return sortedArray[i];
                } else {
                    nonUnique = sortedArray[i];
                }
            }
        }

        return -999999;
    }

    private static int[] bubbleSort(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr.length; j++) {
                if (arr[i] < arr[j]) {
                    int aj = arr[j];
                    int ai = arr[i];
                    arr[j] = ai;
                    arr[i] = aj;
                }
            }
        }

        return arr;
    }
}
