namespace LineCompareProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Line Comparison Computation Program");
            Console.WriteLine("Choose option \t 1.LengthofLine \t 2.Line Equals \t 3.Compare Lines\t4.Using OOPS");
            int check=Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    ModelLine.CalculateLength();
                    break;
                    case 2:
                    LineEquality.LineEquals();
                    break;
                case 3:
                    ComparingLines.CompareLines();
                    break;
                case 4:
                    //UsingOOP usingOOP = new UsingOOP();
                    Console.WriteLine(UsingOOP.CompareLines());

                    Compare compare = new Compare();
                    compare.CompareLines();
                    
                    break;
                default:
                    Console.WriteLine("Enter wrong choice");
                    break;
            }

            
        }
    }
}