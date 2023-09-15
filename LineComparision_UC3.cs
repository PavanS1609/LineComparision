using System;

using System;

class LineComparision_UC3
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
   public static void Result()
    {
        Console.WriteLine(Line1());
        Console.WriteLine(Line2());

        if (Line1 == Line2)
        {
            Console.WriteLine(Line1());
        }
        else
        {
            Console.WriteLine("Line2 is greater than Line1");
        }


    }
}



