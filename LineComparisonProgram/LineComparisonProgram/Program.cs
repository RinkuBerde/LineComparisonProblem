using System.Numerics;

namespace LineComparisonProgram
{
    internal class Program
    {   //variable
        public static int x1, x2, x3, x4, y1, y2, y3, y4;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for x1 coordinator");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y1 coordinator");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x2 coordinator");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y2 coordinator");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x3 coordinator");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y3 coordinator");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x4 coordinator");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y4 coordinator");
            y4 = Convert.ToInt32(Console.ReadLine());



            // created object for class FindLength
            FindLength obj = new FindLength();
            obj.LineLength(x1, y1, x2, y2, x3, y3, x4, y4);

        }
       
    }
    public class FindLength
    {
        public void LineLength(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            //calculating formula for finding length for line1
            double length1 = Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 0.5);
            //calculating formula for finding length for line2
            double length2 = Math.Pow((Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2)), 0.5);
            Console.WriteLine ("length of line 1 is :" + length1);
            Console.WriteLine("length of line 2 is : " + length2);
            //checked both line is equal or not using Equals Method
            if (length1.Equals(length2) == true)
            {
                Console.WriteLine("The line are equal");

            }
            else
            {
                Console.WriteLine("both line is different");
            }



        }
    }
}
    
