import org.junit.Test;
import org.junit.runner.JUnitCore;
import org.junit.runner.Result;
import org.junit.runner.notification.Failure;
import static org.junit.Assert.*;

public class MergeSorterTests {

    @Test
    public void emptyInputReturnsEmptyOutput() {
        int[] input = new int[0];
        int[] expectedOutput = new int[0];
        int[] actualOutput = new MergeSorter().sort(input);
        assertArrayEquals(expectedOutput, actualOutput);
    }
}