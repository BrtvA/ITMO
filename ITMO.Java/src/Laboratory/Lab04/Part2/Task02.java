package Laboratory.Lab04.Part2;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Scanner;

public class Task02 {
    public static void main(String[] args) {
        showArrayElements();
    }

    private static void showArrayElements() {
        System.out.print("Array length: ");
        Scanner scanner = new Scanner(System.in);
        int arrayLength = scanner.nextInt();

        System.out.println("Numbers of array:");
        int[] arr = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++) {
            arr[i] = scanner.nextInt();
        }

        System.out.println("Result: " + Arrays.toString(arr));
    }
}
