using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public abstract class Element
{

    protected Point[] corners = null;


    public Element(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        corners = new Point[4]
        {
            new Point(X, Y),
            new Point(X + Width, Y),
            new Point(X + Width, Y + Height),
            new Point(X, Y + Height)
            
        };
    }

    public int X { get; set; }
    
    public int Y { get; set; }
    
    public int Width { get; set; }
    
    public int Height { get; set; }

    public virtual  bool ContainsPoint(Point point, bool isMouseClicked = false)
    {

        return (this.X <= point.X && point.X <= (this.X + this.Width) 
            && this.Y <= point.Y && point.Y <= (this.Y + this.Height));
    }

    public virtual bool ContainsElement(Element element)
    {
        bool topLeftInside = ContainsPoint(new Point(element.X, element.Y));
        bool bottomRightInside = ContainsPoint(new Point(element.X + element.Width + 10, element.Y + element.Height + 10));

        bool hasTouched = topLeftInside || bottomRightInside;
        
        return hasTouched;
    }

    public double CalculateCollisionAngle(Point hero)
    {
        int arrayIndexStart = Collisions(hero);

        Point startLine = corners[arrayIndexStart];
        Point endLine = corners[(arrayIndexStart + 1) % corners.Length ];

        double angleInRadians = MathHelper.CalculateAngleBetweenTwoDots(startLine.X, startLine.Y, endLine.X, endLine.Y);
        System.Diagnostics.Debug.WriteLine("Angle in degrees:" + MathHelper.ConvertRadiansToDegrees(angleInRadians) + $" Two dots: ({startLine.X},{startLine.Y}), ({endLine.X},{endLine.Y})");
        return angleInRadians;
    }
    private int Collisions(Point hero)
    {

        int minIndex = 0;
        double minDistance = 100;

        for (int i = 0; i < corners.Length; i++) 
        {
            double localDistance = GetDistanceToLine(hero, corners[i], corners[(i + 1) % corners.Length]);
            if (localDistance < minDistance) 
            {
                minDistance = localDistance;
                minIndex = i;
            }
        }

        System.Diagnostics.Debug.WriteLine("CHOSEN side INDEX: " + minIndex + " and " + ((minIndex + 1) % corners.Length));

        return minIndex;
        
    }

    private double GetDistanceToLine(Point sourcePoint, Point point1, Point point2)
    {
        double numerator = Math.Abs((point2.X - point1.X) * (point1.Y - sourcePoint.Y) - (point1.X - sourcePoint.X) * (point2.Y - point1.Y));
        double denominator = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        double distance = numerator / denominator;
        return distance;
    }

    public override string ToString()
    {
        return $"Element Properties:\n" +
               $"- X: {X}\n" +
               $"- Y: {Y}\n" +
               $"- Width: {Width}\n" +
               $"- Height: {Height}\n";
    }
}

