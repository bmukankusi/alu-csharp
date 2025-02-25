

/// <summary>
/// Implementing the IInteractive interface.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Defines the interaction method.
    /// </summary>
    void Interact();
}

/// <summary>
/// The IBreakable interface.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Object durability status.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}

/// <summary>
/// The ICollectable interface.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Indicates whether the object has been collected.
    /// </summary>
    
    bool isCollected { get; set; }

    void Collect();
}

/// <summary>
/// Door class for controlling a door.
/// </summary>

public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for initializing a door with a name.
    /// </summary>
    /// <param name="value">The name of the door.</param>
    
    public Door(string value = "Door")
    {
        name = value;
    }

    
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Decoration class for controlling a decoration.
/// </summary>

public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the entity.
    /// </summary>
    
    public String? name { get; set; }

    /// <summary>
    /// Returns a string representation of the entity.
    /// </summary>
    /// <returns>A formatted string indicating the name and type of the entity.</returns>
    
    public override String ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}