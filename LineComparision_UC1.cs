using System;

// See https://aka.ms/new-console-template for more information

class LineComparision_UC1
{
    static double lineLength()
    {
        double x1 = 3.0;
        double y1 = 3.0;
        double x2 = 4.0;
        double y2 = 4.0;

        double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
        return length;
        Console.WriteLine(lineLength());


    }
}
