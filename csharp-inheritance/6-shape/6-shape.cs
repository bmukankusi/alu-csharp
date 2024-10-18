using System;

class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
class Rectangle : Shape

/// <summary>
/// Class Rectangle ihnerits from Shape
/// </summary>
{
    private int width;
    private int height;

    /// <summary>
    /// Width property
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when width is less than 0</exception>
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

    /// <summary>
    /// Height property
    /// </summary>
    /// <value>get: returns the height, set: sets the height</value>
    /// <exception cref="ArgumentException">Thrown when height is less than 0</exception>
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
}