using System;

class Shape
{

    /// <summary>
    /// Calculate the area of a shape.
    /// </summary>
    /// <returns>Area of the shape</returns>
    /// exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    public virtual int Area()
    {
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }
}