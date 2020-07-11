using System;

namespace EnumString
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Male: {Gender.Male}");
            Console.WriteLine($"Male: {Gender.Female}");
        }
    }
}
