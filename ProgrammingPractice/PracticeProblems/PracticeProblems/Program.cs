using System;

namespace PracticeProblems
{
	class MainClass
	{
		public static void Main (string [] args)
		{
            int x = 722;
            int y = 148;
            int u = 360;
            int v = 176;

            Tuple<int, int> result = AddFractions(x, y, u, v);

            Console.WriteLine("{0}/{1}", result.Item1, result.Item2);
		}

        static Tuple<int, int> AddFractions(int x, int y, int u, int v)
        {
            int lcm = GetLcm(y, v);
            int yMultiple = lcm / y;
            int vMultiple = lcm / v;

            int numerator = x * yMultiple + u * vMultiple;
            int denominator = lcm;

            int hcf = GetHcf(numerator, denominator);

            numerator = numerator / hcf;
            denominator = denominator / hcf;

            return Tuple.Create(numerator, denominator);
        }

        static int GetHcf(int numA, int numB)
        {
            if (numA == numB)
            {
                return numA;
            }

            int high;
            int low;

            if (numA > numB)
            {
                high = numA;
                low = numB;
            }
            else
            {
                high = numB;
                low = numA;
            }

            if (high % low == 0)
            {
                return low;
            }

            int start = low / 2;
            for (int i = start; i > 0; i--)
            {
                if (high % i == 0 && low % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }

        static int GetLcm(int numA, int numB)
        {
            if (numA == numB)
            {
                return numA;    
            }

            int high;
            int low;

            if (numA > numB)
            {
                high = numA;
                low = numB;
            }
            else 
            {
                high = numB;
                low = numA;
            }

            for (int i = 1; i <= low; i++)
            {
                if ((i * high) % low == 0)
                {
                    return (i * high);
                }
            }

            return numA * numB;
        }
	}
}
