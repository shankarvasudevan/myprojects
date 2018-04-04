public class QuickSorter {
    public QuickSorter() {
    }

    public void sort(int[] array, int low, int high) {
        // If low == high, return
        if (low == high) {
            return;
        }

        int partition = partition(array, low, high);
        sort(array, low, partition-1);
        sort(array, partition, high);  
    }

    private int partition(int[] array, int low, int high) {
        // Pick a pivot (high)
        int pivot = array[high];

        // Create a wall (index = low)
        int wall = low;

        // For each element from low to high
        for (int i=low; i < pivot; i++) {
            if (array[i] < pivot) {
                swap(array, wall, i);
                wall++;
            }
        }

        // Perform a series of swaps on the pivot until you reach the wall and move the wall up one
        swap(array, high, wall);

        // Return wall
        return wall;
    }

    private void swap(int[] array, int firstIndex, int secondIndex) {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = array[firstIndex];
    }
}