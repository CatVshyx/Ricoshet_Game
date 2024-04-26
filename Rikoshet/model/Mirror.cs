using System;
using System.Drawing.Drawing2D;

public class Mirror : Element
{

    public Mirror(int x, int y, int width, int height,int angle = 0) : base(x, y, width, height)
    {
        X = x;
        Y = y;
        Angle = angle;
        base.corners = GetRotatedRectangleCorners(new Rectangle(this.X, this.Y, this.Width, this.Height), angle);
    }

    public float Angle { get; set; }
    
    public override bool ContainsPoint(Point point, bool isMouseClicked = false)
    {

        GraphicsPath path = new GraphicsPath();
        path.AddPolygon(corners);

        bool ans = path.IsVisible(point);
        if (ans && isMouseClicked) 
        {
            this.Angle = this.Angle + 30;
            Rectangle rect = new Rectangle(this.X, this.Y, this.Width, this.Height);
            base.corners = GetRotatedRectangleCorners(rect, this.Angle);
        }

        return ans;
    }


    

    private Point[] GetRotatedRectangleCorners(Rectangle rect, float angle)
    {
        Point[] corners =
        {
            new Point(rect.Left, rect.Top),
            new Point(rect.Right, rect.Top),
            new Point(rect.Right, rect.Bottom),
            new Point(rect.Left, rect.Bottom)
        };

        Point center = new Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);

        Matrix matrix = new Matrix();
        matrix.RotateAt(angle, center);
        matrix.TransformPoints(corners);

        return corners;
    }
    
}




