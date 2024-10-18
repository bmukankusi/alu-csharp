// a class Rectangle that inherits from Shape
using System;

class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get { return(width); }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    public int Height
    {
        get { return(height); }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    /// <summary>
    /// Calculate the area of a rectangle.
    /// </summary>
    /// <returns>Rectangle area.</returns>
    public new int Area()
    {
        return(this.width * this.height);
    }

    /// <summary>
    /// Override the ToString method to return the Rectangle width and height.
    /// </summary>
    /// <returns>Rectangle width and height.</returns>
    public override string ToString()
    {
        return($"[Rectangle] {this.width} / {this.height}");
    }
}