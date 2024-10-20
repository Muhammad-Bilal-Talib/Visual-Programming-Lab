using System;

class Program
{
    static void Main()
    {
        int[] ratings = { 1, 2, 3, 3, 4, 5, 2, 3, 4, 4, 5, 2, 3, 1, 4, 5, 2, 3, 4, 5, 1, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 2, 3 };

        int[] numbering = new int[5];

        foreach (int rating in ratings)
        {
            if (rating >= 1 && rating <= 5)
            {
                numbering[rating - 1]++;
            }
        }

        for (int i = 0; i < numbering.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {numbering[i]} people");
        }
    }
}