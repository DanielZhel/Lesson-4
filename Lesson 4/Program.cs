using Lesson_4;

int line = 0 ;
int col = 0;
bool cont = true;

while(cont == true) //Entering lines and columns
{
    Console.Clear();
    cont = false;
    try
    {
        Console.WriteLine("Enter number of matrix lines.");
        line  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of matrix columns.");
        col = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Worng values.Try again!");
        cont = true;
        Console.ReadLine();
    }
    
}

double [,] firstMatrix = new double [line, col];  

 for (int x = 0; x < line; x++)    //Entering matrix values
 {
    for (int y = 0; y < col; y++)
    {
        bool cont2 = true;
        while (cont2 == true)
        {
            cont2 = false;
            try
            {
                Console.WriteLine($"Entered {x}{y} number of the matrix!");
                firstMatrix[x, y] = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("No valid number.Try again.");
                cont2 = true;
            }
        }

    }
    Console.WriteLine();

 }

bool cont3 = true;
while (cont3 == true)
{
    Console.WriteLine("Do you want to look at your matrix?(Yes/No)"); //Display the matrix

    string ans = Console.ReadLine();
    if (ans == "Yes")
    {
        for (int x = 0; x < line; x++)
        {
            for (int y = 0; y < col; y++)
            {
                Console.Write("|" + firstMatrix[x, y] + " ");

            }
            Console.WriteLine();
        }
        cont3 = false;
    }
    else if (ans == "No")
    {
        cont3 = false;
        break;
    }
    else
    {
        Console.WriteLine("No valid action try again");
        cont3 = true;
    }
}

string cont4 = "+";

while(cont4 == "+")
{
    string menu = Menu.Actions(); // Entering menu
    

    if (menu == "1")
    {
        Menu.PosNeg(line, col, firstMatrix);
        cont4 = Menu.Continue();
        Console.ReadLine();
    }
    else if (menu == "2")
    {
        Menu.SortedMatrix(line, col, firstMatrix);
        cont4 = Menu.Continue();
    }
    else if (menu == "3") // positive humbers to negative. negative to positive
    {
        Menu.Inversion(line, col, firstMatrix);
        cont4 = Menu.Continue();
    }

}


