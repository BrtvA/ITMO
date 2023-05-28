package Laboratory.Lab04.Part2;

import java.util.Arrays;
import java.util.Random;

public class Task05 {
    public static void main(String[] args) {
        int[] arr = generateArray(6, 100);

        System.out.println(Arrays.toString(arr));
        System.out.println(Arrays.toString(mergeSort(arr)));
    }

    private static int[] generateArray(int arrayLength, int maxValue) {
        int[] arr = new int[arrayLength];

        for (int i = 0; i < arr.length; i++) {
            arr[i] = (int) (Math.random() * maxValue);
        }

        return arr;
    }

    private static int[] mergeSort(int[] ints) {
        if (ints.length < 2) {
            return ints;
        }

        int mid = ints.length / 2;

        int[] left = new int[mid];

        int[] right;

        if (ints.length % 2 == 0) {
            right = new int[mid];
        } else {
            right = new int[mid + 1];
        }

        for (int i = 0; i < left.length; i++) {
            left[i] = ints[i];
        }

        for (int i = 0; i < right.length; i++) {
            right[i] = ints[mid + i];
        }

        left = mergeSort(left);
        right = mergeSort(right);

        return mergeParts(left, right);


    }

    private static int[] mergeParts(int[] left, int[] right) {
        int[] result = new int[left.length + right.length];

        int leftPointer = 0;
        int rightPointer = 0;
        int resultPointer = 0;

        while (leftPointer < left.length || rightPointer < right.length) {
            if (leftPointer < left.length && rightPointer < right.length) {
                if (left[leftPointer] < right[rightPointer]) {
                    result[resultPointer++] = left[leftPointer++];
                } else {
                    result[resultPointer++] = right[rightPointer++];
                }
            } else if (leftPointer < left.length) {
                result[resultPointer++] = left[leftPointer++];

            } else if (rightPointer < right.length) {
                result[resultPointer++] = right[rightPointer++];
            }
        }

        return result;
    }
}
