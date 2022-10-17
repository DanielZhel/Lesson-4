using Lesson_4;
using Microsoft.VisualBasic;
using System;

Console.WriteLine("Enter A number: AxA - this is your matrix's size.");

int A  = Convert.ToInt32(Console.ReadLine());

double [,] firstMatrix = new double [A, A];
 for (int x = 0; x < A; x++)    //Entering matrix values
 {
     for (int y = 0; y < A; y++)
     {
        Console.WriteLine($"Entered {x}{y} number of the matrix"); 
        firstMatrix[x,y] = Convert.ToDouble (Console.ReadLine());
     }

    Console.WriteLine();

 }

Console.WriteLine("Do you wnat to look at your matrix?(Yes/No)"); //Display the matrix

string ans = Console.ReadLine();

if (ans == "Yes")
{
    for (int x = 0; x < A; x++)
    {
        for (int y = 0; y < A; y++)
        {
            Console.Write("|"+firstMatrix[x, y] + " ");

        }
        Console.WriteLine(); 
    }
}

Console.WriteLine("Choose the number of action:");
Console.WriteLine("1.Show the number of positive/negative:");
Console.WriteLine("2.Sorting matrix elements row by row.");
Console.WriteLine("3.Invert matrix elements row by row."); 
string menu = Console.ReadLine();

if (menu == "1")
{
    string choosePosNeg = "";
    Menu.posNeg(ref choosePosNeg);
    if (choosePosNeg == "positive")
    {
        int i = 0;
        for (int x = 0; x < A; x++)
        {
            for (int y = 0; y < A; y++)
            {
                if(firstMatrix[x,y] > 0)
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
        for (int x = 0; x < A; x++)
        {
            for (int y = 0; y < A; y++)
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
else if (menu == "2")
{
    string chooseSort = "";
    Menu.sortEl(ref chooseSort);
   
    if (chooseSort == "1")
    {
        for (int x = 0; x < A; x++)
        {
            for (int y = 0; y < A; y++)
            {  
                
                while (firstMatrix[x, y] > firstMatrix[x++, y++])
                {
                    firstMatrix[x, y] = firstMatrix[x++, y++];
                        
                }

                Console.WriteLine(firstMatrix[x, y]);

            }

            Console.WriteLine();

        }
    }
}
else if (menu == "3")
{
    string inversion = "";
    Menu.matrixInversion (ref inversion);
    double[,] newMatrix = new double[A, A];
    if (inversion == "Yes")
    {
        
        for (int x = 0; x < A; x++)
        {
            for (int y = 0; y < A; y++)
            {  
                newMatrix[x,y] = - firstMatrix[x, y];
                Console.Write("|" + newMatrix[x,y] + " ");
            }
            Console.WriteLine();
        }
    }
    
}


