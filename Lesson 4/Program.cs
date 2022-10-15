using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter A number: AxA - this is your matrix's size.");

int A  = Convert.ToInt32 (Console.ReadLine());

int [,] firstMatrix = new int [A, A];
 for (int x = 0; x < A; x++)
 {
     for (int y = 0; y < A; y++)
     {
        Console.WriteLine($"Entered {x}{y} number of the matrix");
        firstMatrix[x,y] = Convert.ToInt32 (Console.ReadLine());
     }

    Console.WriteLine();

 }

Console.WriteLine("Do you wnat to look at your matrix?(Yes/No)");

string ans = Console.ReadLine();

if (ans == "Yes")
{
    for (int x = 0; x < A; x++)
    {
        for (int y = 0; y < A; y++)
        {
            Console.Write(firstMatrix[x,y]);
            
        }
        Console.WriteLine();    
    }
}
else
{
    Console.WriteLine("Сlick something to continue.");
}



