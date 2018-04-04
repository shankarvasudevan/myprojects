import java.io.*;
import java.io.BufferedReader;

public class Main {
    
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String inputStr = reader.readLine();
        String[] inputs = inputStr.split(" ");
        int[] arr = new int[inputs.length];
        for (int i=0; i < inputs.length; i++) {
            arr[i] = Integer.parseInt(inputs[i]);
        }

        QuickSorter sorter = new QuickSorter();
        sorter.sort(arr, 0, arr.length-1);
        PrintArray(arr);
    }

    private static void PrintArray(int[] arr) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < arr.length; i++) {
            if (i > 0) {
                sb.append(", ");
            }
            sb.append(arr[i]);
        }

        System.out.println(sb.toString());
    }
}
