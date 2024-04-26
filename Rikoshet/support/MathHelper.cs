using System;

public static class MathHelper
{

    public static double CalculateAngleBetweenTwoDots(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;

        return Math.Atan2(dy, dx);
    }

    public static double ConvertDegreesToRadians(int angleInDegrees) 
    {
        return angleInDegrees * (Math.PI / 180);

    }
    public static double ConvertDegreesToRadians(double angleInDegrees)
    {
        return angleInDegrees * (Math.PI / 180);

    }
    public static double ConvertRadiansToDegrees(double angleInRadians) 
    {
        return angleInRadians * (180 / Math.PI);
    }
    public static Point FindMidPoint(Point point1, Point point2)
    {
        int midX = (point1.X + point2.X) / 2;
        int midY = (point1.Y + point2.Y) / 2;

        return new Point(midX, midY);
    }
    public static float CalculateDistance(Point point1, Point point2)
    {
        int deltaX = point2.X - point1.X;
        int deltaY = point2.Y - point1.Y;

        float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return distance;
    }
}
