public class MergeSorter {
    public MergeSorter() {
    }

    public int[] sort(int[] arr) {
        if (arr.length == 1) {
            return arr;
        }

        int start = 0;
        int end = arr.length;
        int mid = (start+end)/2;

        int[] unsortedLeft = CopyFrom(arr, start, mid);
        int[] unsortedRight = CopyFrom(arr, mid, end);

        int[] sortedLeft = sort(unsortedLeft);
        int[] sortedRight = sort(unsortedRight);

        return Merge(sortedLeft, sortedRight);  
    }

    private static int[] Merge(int[] left, int[] right) {
        int[] result = new int[left.length+right.length];

        int leftIndex = 0;
        int rightIndex = 0;
        int resultIndex = 0;

        while (resultIndex < result.length) {
            if (rightIndex >= right.length) {
                result[resultIndex++] = left[leftIndex++];
            } else if (leftIndex >= left.length) {
                result[resultIndex++] = right[rightIndex++];
            } else if (left[leftIndex] > right[rightIndex]) {
                result[resultIndex++] = right[rightIndex++];
            } else {
                result[resultIndex++] = left[leftIndex++];
            }
        }

        return result;
    }

    private static int[] CopyFrom(int[] original, int from, int to) {
        int length = to-from;
        int[] result = new int[length];

        for (int i=0; i < length; i++) {
            result[i] = original[from+i];
        }

        return result;
    }
}