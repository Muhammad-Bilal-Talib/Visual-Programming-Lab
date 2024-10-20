using System;

namespace multiplearray
    {
class Program
{
    static void Main()
    {
        // Step 1: Input two 3x3 matrices
        int[,] matrix_1 = new int[3, 3];
        int[,] matrix_2 = new int[3, 3];
        int[,] Result = new int[3, 3];

        Console.WriteLine("Enter elements of matrix:");
        Input_Matrix(matrix_1);

        Console.WriteLine("Enter elements of matrix:");
        Input_Matrix(matrix_2);

       
        Multiply_Matrices(matrix_1, matrix_2, Result);

       
        Console.WriteLine("Resultant Matrix:");
        Display_Matrix(Result);
    }

    static void Input_Matrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }


    static void Multiply_Matrices(int[,] A, int[,] B, int[,] result)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = 0; 
                for (int k = 0; k < 3; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }


    static void Display_Matrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine(); 
        }
    }
}
}

