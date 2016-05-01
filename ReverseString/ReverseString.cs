using System;

public class ReverseString
{
    public static void Main(string[] args)
    {
        string inputString = "test";
        char[] input = inputString.ToCharArray();
        char[] reversedInput = new char[input.Length];
        
        for (int i=0; i < input.Length; i++)
        {
            reversedInput[i] = input[inputLength-1-i];
        }
        
        Console.WriteLine(reversedInput);
    }
}