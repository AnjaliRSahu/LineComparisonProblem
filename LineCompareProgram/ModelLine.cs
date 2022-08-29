using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProgram
{
    internal class ModelLine
    {
        public static void CalculateLength()
        {
            int x1,y1,x2,y2;
            Console.WriteLine("Enter  Coordinates value of x1 y1 x2 and y2");
            x1=Convert.ToInt32(Console.ReadLine());
            y1=Convert.ToInt32(Console.ReadLine()); 
            x2=Convert.ToInt32(Console.ReadLine()); 
            y2 = Convert.ToInt32(Console.ReadLine());  


            double length =Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            
            Console.WriteLine("Length of the line :" + length);
                        

        }





    }
}
