
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
    public new int Area()
    {
        return(this.width * this.height);
    }
    public override string ToString()
    {
        return($"[Rectangle] {this.width} / {this.height}");
    }
}
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when size is less than 0</exception>
    public int Size
    {
        get { return(size); }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
                {
                    size = value;
                    Height = value;
                    Width = value;
                }
        }
    }
}