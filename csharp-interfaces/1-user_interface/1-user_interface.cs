﻿
/// <summary>
/// Create an abstract class called Base.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// <value>The name of the entity.</value>
    /// </summary>
    
    public string? name { get; set; }

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Provides an interface for interactive objects.
/// </summary>
/// <remarks>Interactive objects can be interacted with.</remarks>

public interface IInteractive
{
    /// <summary>
    /// Method for interacting with an object.
    /// </summary>
    
    void Interact();
}

/// <summary>
/// Creates an interface for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method for breaking an object.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the object is collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect method.
    /// </summary>
    void Collect();
}

/// <summary>
/// TestObject class.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the object is collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Interaction behavior.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"{name} interacts.");
    }

    /// <summary>
    /// Breaking behavior.
    /// </summary>
    public void Break()
    {
        Console.WriteLine($"{name} breaks.");
    }

    /// <summary>
    /// Collecting behavior.
    /// </summary>
    public void Collect()
    {
        isCollected = true;
        Console.WriteLine($"{name} is collected.");
    }
}