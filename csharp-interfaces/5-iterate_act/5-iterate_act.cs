
public abstract class Base {

    public string? name { get ; set; }
/// <summary>
/// ToString() method
/// </summary>

    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

/// <summary>
/// IInteractive interface
/// </summary>
public interface IInteractive {


    public void Interact();
}


public interface IBreakable {


    public int durability { get ; set;}

    public void Break();
}

public interface ICollectable{

    public bool isCollected { get ; set; }

/// <summary>
/// collect method
/// </summary>
    public void Collect();

}

/// <summary>
/// class Door
/// </summary>

public class Door : Base , IInteractive{

/// <summary>
/// constructor that sets the value of name
/// </summary>
/// <param name="value"></param>
    public Door(string value = "Door"){
        name = value;
    }

/// <summary>
/// Interact() implementation
/// </summary>
    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// decoration base inheriting from base, iinteractive, ibreakable
/// </summary>
public class Decoration : Base, IInteractive, IBreakable {

/// <summary>
/// isquestitem prp
/// </summary>
    public bool isQuestItem { get; set; }

/// <summary>
/// durability prp
/// </summary>
    public int durability { get; set; } 

/// <summary>
/// Decoration
/// </summary>
/// <param name="Name"></param>
/// <param name="durability"></param>
/// <param name="isQuestItem"></param>
/// <exception cref="ArgumentException"></exception>
    public Decoration(string Name = "Decoration", int durability = 1, bool isQuestItem= false) {

        this.isQuestItem = isQuestItem;
        name = Name;

        if (durability <= 0) {
            throw new ArgumentException("Durability must be greater than 0");
        }
        else {
            this.durability = durability;
        }

    }

/// <summary>
/// interact implementation
/// </summary>
    public void Interact()
    {
        if (durability <= 0) {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem) {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

/// <summary>
/// break implementation
/// </summary>
    public void Break() {
       
            this.durability--;
            if (durability > 0) {
                Console.WriteLine($"You hit the {name}. It cracks.");
            }
            if (durability == 0) {
                Console.WriteLine($"You smash the {name}. What a mess.");
            }
        
            if (durability < 0) {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}


public class Key: Base, ICollectable {


    public bool isCollected { get; set; }

/// <summary>
/// Returns a new instance of the Key class
/// Constructor for initializing a key with a name and isCollected
/// </summary>
/// <param name="Name"></param>
/// <param name="isCollected"></param>

    public Key(string Name = "Key", bool isCollected = false) {

        name = Name;
        this.isCollected = isCollected;
    }

/// <summary>
/// collect method
/// </summary>
    public void Collect() {
        if (!isCollected) {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary>
/// RoomObjects class
/// </summary>

public class RoomObjects {

/// <summary>
/// iterateaction method
/// </summary>
/// <param name="roomObjects"></param>
/// <param name="type"></param>
    public static void IterateAction(List<Base> roomObjects, Type type) {

        foreach (var obj in roomObjects) {

            if (typeof(Door).GetInterfaces().Contains(type))
            {
                IInteractive? current = obj as IInteractive;
                current?.Interact();
            }
            else if (typeof(Decoration).GetInterfaces().Contains(type))
            {
                IBreakable? current = obj as IBreakable;
                current?.Break();
            }
            else if (typeof(Key).GetInterfaces().Contains(type))
            {
                ICollectable? current = obj as ICollectable;
                current?.Collect();
            }
      }
    }
}