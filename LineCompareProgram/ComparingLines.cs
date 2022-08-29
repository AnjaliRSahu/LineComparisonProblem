using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProgram
{
    internal class ComparingLines
    {
        public static void CompareLines()
        {
            int x1, y1, x2, y2;
            Console.WriteLine("Enter  Coordinates value of first line");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

            //Console.WriteLine("Length of the line :" + length1);

            int m1, n1, m2, n2;
            Console.WriteLine("Enter  Coordinates value of second line");
            m1 = Convert.ToInt32(Console.ReadLine());
            n1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt((m2 - m1) ^ 2 + (n2 - n1) ^ 2);

            //Console.WriteLine("Length of the line :" + length2);

            double res=length1.CompareTo(length2);
            if (res > length1 && res < length2)
                Console.WriteLine("Line 1 is greater ");
            else if (res > length2 && res < length1)
                Console.WriteLine("Line 2 is greater");
            else if (length1 == length2)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Invalid");

        }




    }
}
