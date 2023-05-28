package Laboratory.Lab04.Part1;

public class Task06 {
    public static void main(String[] args) {
        int[] arr = {3, -3, 7, 4, 5, 4, 3};

        System.out.println(checkArray(arr));
    }

    private static boolean checkArray(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == 1 || arr[i] == 3) {
                return true;
            }
        }
        return false;
    }
}
