// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace LineComparisionProblemDay8
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Problem using OOP Concept.");
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter x coordinate of point1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of point2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            CartesianSystemNonStatic csns = new CartesianSystemNonStatic();
            csns.calculateLength(x1, y1, x2, y2);
            Console.WriteLine("\n");

            Console.WriteLine("To Check Both Line Equals or not by Equals method");
            Console.WriteLine("\n--------------------------------------*-----");
            Console.WriteLine("\n");
            Console.WriteLine("Enter start and end points of First line: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());


            CheckEqualOrNot length = new CheckEqualOrNot();
            length.CheckEqualityOfLength(a1, b1, a2, b2);
            Console.WriteLine("\n");
        }
    }
}

