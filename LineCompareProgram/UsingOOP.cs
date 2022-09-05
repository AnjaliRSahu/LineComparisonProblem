using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProgram
{
    public class UsingOOP
    {
        //method  overloading 
        public static double  CompareLines()
        {
            int x1 = 5, y1 = 4, x2 = 6, y2 = 8;


            double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

            //Console.WriteLine("Length of the line :" + length1);
            return length1; 
        }
    }
    public class Compare:UsingOOP
    {
        double length1 = UsingOOP.CompareLines();
        public void CompareLines()
        {
            int m1 = 1, n1 = 3, m2 = 6, n2 = 9;


               double length2 = Math.Sqrt((m2 - m1) ^ 2 + (n2 - n1) ^ 2);

                //Console.WriteLine("Length of the line :" + length2);
            
                double res = length1.CompareTo(length2);
            if (res > 0)
                Console.WriteLine("Line 1 is greater ");
            else if (res < 0)
                Console.WriteLine("Line 2 is greater");
            else
                Console.WriteLine("Lines are equal");
        }
          
    }
    

        
    
}
