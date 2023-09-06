using System;

class LineComparision_UC2
{
    static double Line1()
    {
        double x1 = 1.0;
        double x2 = 2.0;
        double y1 = 3.0;
        double y2 = 4.0;
        double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
        return Line1();
    }
    static double Line2()
    {
        double x1 = 1.0;
        double x2 = 2.0;
        double y1 = 3.0;
        double y2 = 4.0;
        double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
        return Line2();
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Line1());
        Console.WriteLine(Line2());
    }
}


