using System;

public class Enemy : Element
{

    public int ImageId { get; set; }

    public Enemy(int x, int y, int imageId, int width = 100, int height = 100) : base(x, y, width,height)
    {
        X = x;
        Y = y;
        ImageId = imageId;
    }
}
