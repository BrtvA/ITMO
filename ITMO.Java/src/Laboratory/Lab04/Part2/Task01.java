package Laboratory.Lab04.Part2;

public class Task01 {
    public static void main(String[] args) {
        int[] arr = {0, 1, 1, 2, 3, 4};

        System.out.println(checkSortedArray(arr));
    }

    private static String checkSortedArray(int[] arr) {
        for (int i = 1; i < arr.length; i++) {
            if (arr[i] < arr[i - 1]) {
                return "Please, try again";
            }
        }
        return "Ok";
    }
}
