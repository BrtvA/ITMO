package Laboratory.Lab04.Part2;

import java.util.Arrays;

public class Task03 {
    public static void main(String[] args) {
        int[] arr = {5, 6, 7, 2};

        System.out.println(Arrays.toString(arr));
        System.out.println(Arrays.toString(changeArrayElements(arr)));
    }

    private static int[] changeArrayElements(int[] arr) {
        int first = arr[0];
        int last = arr[arr.length - 1];
        arr[0] = last;
        arr[arr.length - 1] = first;

        return arr;
    }
}
