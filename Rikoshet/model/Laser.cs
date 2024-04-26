using System;

public class Laser : Element
{
    public double DirectionX { get; set; }

    public double DirectionY { get; set; }

    private double angle;

    public double Angle
    {
        get { return angle; }
    }

    public Laser(int x, int y, int width = 6, int height = 3) : base(x, y, width, height)
    {
    }
    
    public void SetLaserAngle(double angleRadians) 
    { 
        this.angle = angleRadians % (2 * Math.PI);
        System.Diagnostics.Debug.WriteLine("Laser angle set:" + MathHelper.ConvertRadiansToDegrees(this.angle) + " (degres)");
        double sinValue = (double) Math.Sin(this.angle);
        double cosValue = (double) Math.Cos(this.angle);

        this.DirectionX = cosValue * 10;
        this.DirectionY = sinValue * 10;
        System.Diagnostics.Debug.WriteLine("Laser speedx:" + this.DirectionX + " spedy:" + this.DirectionY);
    }
    public void MakeRikoshet() 
    {
        SetLaserAngle(this.angle + MathHelper.ConvertDegreesToRadians(90)); 
    }
    
    
}
