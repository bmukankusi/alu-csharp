
/// <summary>
/// Create an abstract class called Base
/// </summary>
public abstract class Base{

///<summary>
/// The name of the object
/// </summary>
    public String? name;

/// <summary>
/// Override the ToString method
/// </summary>
/// <returns></returns>
    public override String ToString(){
        return $"{name} is a {this.GetType()}";
    }
}