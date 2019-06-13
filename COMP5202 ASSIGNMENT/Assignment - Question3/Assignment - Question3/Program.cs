using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Question3
{
    class Program
    { //Liam Sullivan ID:30022060 COMP.5202 Assignment
        public static void Main(string[] args)
        {

            Random rdm = new Random();

            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] matrixC = new int[3, 3];

            Console.WriteLine("***ARRAY A***\n-------------");

            for (int q = 0; q < matrixA.GetLength(0); q++)
            {
                for (int w = 0; w < matrixA.GetLength(1); w++)
                {
                    matrixA[q, w] = rdm.Next((-10), 10);
                }
                Console.WriteLine();

            }
            Array(matrixA); //shows the 3x3 matrixA

            Console.WriteLine("\n***ARRAY B***\n-------------");

            for (int q = 0; q < matrixB.GetLength(0); q++)
            {
                for (int w = 0; w < matrixB.GetLength(1); w++)
                {
                    matrixB[q, w] = rdm.Next((-10), 10);
                }
                Console.WriteLine();

            }
            Array(matrixB); //shows the 3x3 matrixB

            Console.WriteLine("\n***ARRAY A + ARRAY B = ARRAY C***\n-------------");

            for (int q = 0; q < matrixC.GetLength(1); q++)
            {
                for (int w = 0; w < matrixC.GetLength(1); w++)
                {
                    Console.Write(matrixA[q, w] + matrixB[q, w] + " "); //adds both matrixA and matrixB to create MatrixC
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }


        public static void Array(int[,] array) //code to display matrixes in a 3x3 grid
        {
            for (int q = 0; q < array.GetLength(0); q++)
            {
                for (int w = 0; w < array.GetLength(1); w++)
                {
                    Console.Write(array[q, w] + " ");
                }
                Console.ReadLine();

            }
        }
    }
}
