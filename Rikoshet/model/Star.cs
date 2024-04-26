using System;

public class Star : Element
{
	public Color Color { get; set; }

    public Star(int x, int y, int width, int height, Color color) : base(x, y, width, height)
    {
        Color = color;
	}
}
