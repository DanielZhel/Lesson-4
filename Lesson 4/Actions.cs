using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public static class Menu
    {

        public static string posNeg()
        {
            Console.WriteLine("Show the number of positive/negative");
            string choise = Console.ReadLine();
            return choise;
        }

        public static string sortEl()
        {
                Console.WriteLine("Choose the number of action: 1. From largest to smallest. / 2.From smallest to largest.");
                string sortEl = Console.ReadLine();
                return sortEl;
        }
    
        public static string Actions()
        {
            string act ="";
            bool cont = true;

            while(cont == true)  
            {
                Console.WriteLine("Choose the number of action:");
                Console.WriteLine("1.Show the number of positive/negative:");
                Console.WriteLine("2.Sorting matrix elements row by row.");
                Console.WriteLine("3.Invert matrix elements row by row.");
                act = Console.ReadLine();
                if (act == "1" || act == "2" || act == "3")
                {
                    cont = false;
                    break;
                }
                else
                    cont = true;
                    continue;
            }
            
            return act;
        }
        public static void PosNeg(int line, int col, double[,] firstMatrix)
        {
            string choosePosNeg = Menu.posNeg();
           
            if (choosePosNeg == "positive")
            {
                int i = 0;
                for (int x = 0; x < line; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        if (firstMatrix[x, y] > 0)
                        {
                            i++;
                        }
                        else
                        {
                            i = i;
                        }
                    }
                }

                Console.WriteLine($"The number of positive numbers is {i}! ");

            }

            else if (choosePosNeg == "negative")
            {
                int j = 0;
                for (int x = 0; x < line; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        if (firstMatrix[x, y] < 0)
                        {
                            j++;
                        }
                        else
                        {
                            j = j;
                        }
                    }
                }

                Console.WriteLine($"The number of negative numbers is {j}! ");
            }
        }
        public static void SortedMatrix(int line, int col, double[,] firstMatrix)
        {
            string chooseSort = Menu.sortEl();

            for (int x = 0; x < line; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    for (int z = 0; z < col - 1; z++)
                    {
                        if (chooseSort == "1")
                        {
                            if (firstMatrix[x, z] < firstMatrix[x, z + 1])
                            {
                                double temp = firstMatrix[x, z];
                                firstMatrix[x, z] = firstMatrix[x, z + 1];
                                firstMatrix[x, z + 1] = temp;
                            }
                        }
                        else if (chooseSort == "2")
                        {
                            if (firstMatrix[x, z] > firstMatrix[x, z + 1])
                            {
                                double temp = firstMatrix[x, z];
                                firstMatrix[x, z] = firstMatrix[x, z + 1];
                                firstMatrix[x, z + 1] = temp;
                            }
                        }
                    }

                }
            }

            for (int x = 0; x < line; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.Write("|" + firstMatrix[x, y] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }

        public static void Inversion(int lines, int col, double[,] Matrix)
        {
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col / 2; j++)
                {
                    double temporary = Matrix[i, j];
                    Matrix[i, j] = Matrix[i, col - (1 + j)];
                    Matrix[i, col - (1 + j)] = temporary;
                }
            }
            for (int x = 0; x < lines; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.Write("|" + Matrix[x, y] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
        public static string Continue()
        {
            string cont = "";
            bool next = true;
            while (next == true)
            {
                
                Console.WriteLine("Do you want to continue?(+/-)");
                cont = Console.ReadLine();

                if (cont == "+" || cont == "-")
                {
                    next = false;
                }
                else
                    next = true;
            }
            return cont;
        }     
    }
}

