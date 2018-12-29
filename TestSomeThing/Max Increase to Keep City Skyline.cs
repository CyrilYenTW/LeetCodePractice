using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Max_Increase_to_Keep_City_Skyline
    {
        public Max_Increase_to_Keep_City_Skyline()
        {
            //int[,] grid = new int[,] { { 3, 0, 8, 4 }, { 2, 4, 5, 7 }, { 9, 2, 6, 3 }, { 0, 3, 1, 0 } };   

            int[][] grid = new int[4][]
            {
                new int[] { 3, 0, 8, 4 },
                new int[] { 2, 4, 5, 7 },
                new int[] { 9, 2, 6, 3 },
                new int[] { 0, 3, 1, 0 }
            };

            GetOutpu(grid);
        }

        public int GetOutpu(int[][] grid)
        {
            var rowCount = grid.GetLength(0);
            var columnCount = grid[0].GetLength(0);

            var dicRowMax = new Dictionary<int, int>();
            var dicColumnMax = new Dictionary<int, int>();

            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                dicRowMax.Add(rowIndex, grid[rowIndex].Max());

                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    dicColumnMax[columnIndex] = dicColumnMax.ContainsKey(columnIndex) ? Math.Max(dicColumnMax[columnIndex], grid[rowIndex][columnIndex]) : grid[rowIndex][columnIndex];
                }
            }

            var result = 0;

            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    var currentValue = grid[rowIndex][columnIndex];
                    var minValue = Math.Min(dicRowMax[rowIndex], dicColumnMax[columnIndex]);
                    var correctValue = Math.Max(currentValue, minValue);
                    result += correctValue - currentValue;
                }
            }

            return result;
        }
    }
}
