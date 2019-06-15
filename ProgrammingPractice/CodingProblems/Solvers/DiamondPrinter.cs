using System;

namespace Solvers
{
    public class DiamondPrinter
    {
        public string PrintDiamond(int n)
        {
            if (n <= 0)
            {
                return string.Empty;
            }

            int numRows = 2 * n - 1;

            /*
             * Example n=4:
             *    1   
             *   121   
             *  12321 
             * 1234321
             *  12321
             *   121
             *    1
             *  
             */

            string diamond = string.Empty;
            for (int row = 0; row < numRows; row++)
            {
                string rowLine = PrintRow(row, n, numRows);
                diamond += rowLine + Environment.NewLine;
            }

            return diamond;
        }

        private string PrintRow(int rowIndex, int n, int numRows)
        {
            string rowLine = string.Empty;
            int numSpaces = CalculateNumSpaces(rowIndex, n);

            // Left spaces
            for (int i = 0; i < numSpaces; i++)
            {
                rowLine += " ";
            }

            // Ascending numbers to centre
            int nextDigit = 0;
            for (int i = numSpaces; i < n; i++)
            {
                nextDigit++;
                rowLine += nextDigit;
            }

            // Descending from centre
            for (int i = n; i < (numRows - numSpaces); i++)
            {
                nextDigit--;
                rowLine += nextDigit;
            }

            // Right spaces
            for (int i = n - numSpaces; i < numRows; i++)
            {
                rowLine += " ";
            }

            return rowLine;
        }

        private int CalculateNumSpaces(int rowIndex, int n)
        {
            if (rowIndex < n)
            {
                return n - rowIndex - 1;
            }

            return rowIndex % n + 1;
        }
    }
}
