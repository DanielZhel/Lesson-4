using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public static class Menu
    {
        
        public static void posNeg(ref string posNeg)
        {   
            Console.WriteLine("show the number of positive/negative");
            posNeg = Console.ReadLine();
            return;
        }

        public static void sortEl (ref string sortEl)
        {
            Console.WriteLine("Choose the number of action: 1. From largest to smallest. / 2.From smallest to largest.");
            sortEl = Console.ReadLine();
            return;
        }
        public static void matrixInversion(ref string matrixInversion)
        {
            Console.WriteLine("Do you want to inver matrix?(Yes/No)");
            matrixInversion = Console.ReadLine();
            return;
        }
    }
}
