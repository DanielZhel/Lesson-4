Console.WriteLine("Enter A number: AxA - this is your matrix's size.");

int A  = Convert.ToInt32(Console.ReadLine());

double [,] firstMatrix = new double [A, A];
 for (int x = 0; x < A; x++)
 {
     for (int y = 0; y < A; y++)
     {
        Console.WriteLine($"Entered {x}{y} number of the matrix");
        firstMatrix[x,y] = Convert.ToDouble (Console.ReadLine());
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
            Console.Write(firstMatrix[x, y]);

        }
        Console.WriteLine();
    }
}
Console.WriteLine("show the number of positive/negative");
string posNeg = Console.ReadLine();

if (posNeg == "positive")
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
else if (posNeg == "negative")
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


