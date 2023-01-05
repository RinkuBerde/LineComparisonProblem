namespace LineComparisonProgram
{
    internal class Program
    {   //variable
        public static int x1, x2, y1, y2, i;
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
            // created object for class FindLength
            FindLength obj = new FindLength();
            obj.LineLength(x1, y1, x2, y2, i);
        }
    }
    public class FindLength
    {
        public void LineLength(int x1, int y1, int x2, int y2, int i)
        {
            //calculating formula for finding length
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Math.Round(sqrt, 2));
        }
    }
}
    
