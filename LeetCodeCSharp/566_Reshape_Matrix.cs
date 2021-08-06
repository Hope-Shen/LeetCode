using System;

namespace LeetCodeCSharp_Reshape_Matrix
{
    /*
    566_Reshape_Matrix
    2021/08/07

    In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one with a different size r x c keeping its original data.
    You are given an m x n matrix mat and two integers r and c representing the number of rows and the number of columns of the wanted reshaped matrix.
    The reshaped matrix should be filled with all the elements of the original matrix in the same row-traversing order as they were.
    If the reshape operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

    Example 1:
    Input: mat = [[1,2],[3,4]], r = 1, c = 4
    Output: [[1,2,3,4]]
   
    Example 2:
    Input: mat = [[1,2],[3,4]], r = 2, c = 4
    Output: [[1,2],[3,4]]
    */
    public class Reshape_Matrix
    {
        // Time complexity: O(m*n)
        // Space complexity: O(m*n)
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (r * c != mat.Length * mat[0].Length) return mat;

            int[][] result = new int[r][];

            int result_row = 0;
            int result_col = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (result_col == 0)
                    {
                        result[result_row] = new int[c];
                    }
                    result[result_row][result_col] = mat[i][j];
                    if (result_col == c - 1)
                    {
                        result_row++;
                        result_col = 0;
                    }
                    else
                    {
                        result_col++;
                    }
                }
            }
            // for (int i = 0; i < result.Length; i++)
            // {
            //     System.Console.WriteLine("{0}", string.Join(",", result[i]));
            // }
            return result;
        }


        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Reshape Matrix-----");
            int[][] mat_1 = new int[][]
            {
                new int[] {1,2},
                new int[] {3,4}
            };
            MatrixReshape(mat_1, 1, 4);
            MatrixReshape(mat_1, 2, 2);
            MatrixReshape(mat_1, 4, 1);
            int[][] mat_2 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6}
            };
            MatrixReshape(mat_2, 1, 6);
            MatrixReshape(mat_2, 2, 3);
        }
    }
}