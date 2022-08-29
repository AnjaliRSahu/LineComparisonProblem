using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProgram
{
    internal class LineEquality
    {
        public static void LineEquals()
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
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double  length2= Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

            //Console.WriteLine("Length of the line :" + length2);
            
            if (Equals(length1, length2))
                Console.WriteLine("Length of both lines are equal");
            else
                Console.WriteLine("Lines are not equal");

        }
    }
}
