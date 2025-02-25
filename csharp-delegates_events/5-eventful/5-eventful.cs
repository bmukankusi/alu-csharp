/// <summary>
/// CurrentHPArgs class, inherits from EventArgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Current health points.
    /// </summary>
    public float currentHp;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentHPArgs"/> class.
    /// </summary>
    /// <param name="newHp">The new health points.</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

/// <summary>
/// Enum for modifiers.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier.
    /// </summary>
    Weak,

    /// <summary>
    /// Base modifier.
    /// </summary>
    Base,

    /// <summary>
    /// Strong modifier.
    /// </summary>
    Strong
}

/// <summary>
/// Delegate for calculating modifiers.
/// </summary>
/// <param name="baseValue">The base value.</param>
/// <param name="modifier">The modifier.</param>
/// <returns>The calculated value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Player class.
/// </summary>
public class Player
{
    // Player name
    private string name = "Player";

    // Player max health
    private float maxHp = 100f;

    // Player standard health
    private float hp;

    // Event handler for HP check
    EventHandler<CurrentHPArgs> HPCheck;

    // Player status
    private string status;

    // Calculate health delegate
    delegate void CalculateHealth(float amount);

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The player name.</param>
    /// <param name="maxHp">The player max health.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.name = name;
        hp = this.maxHp;
        status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Damages the player.
    /// </summary>
    /// <param name="damage">The damage amount.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            hp -= damage;
            Console.WriteLine($"{name} takes {damage} damage!");
        }
        ValidateHP(hp);
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    /// <param name="heal">The heal amount.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            hp += heal;
            Console.WriteLine($"{name} heals {Math.Round(heal, 1)} HP!");
        }
        ValidateHP(hp);
    }

    /// <summary>
    /// Validates the player's health points.
    /// </summary>
    /// <param name="newHp">The new health points.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }

        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies a modifier to a base value.
    /// </summary>
    /// <param name="baseValue">The base value.</param>
    /// <param name="modifier">The modifier.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }

        if (modifier == Modifier.Base)
        {
            return baseValue;
        }

        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }

        return default(float);
    }

    /// <summary>
    /// Checks the player's status based on current health points.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments.</param>
    private void CheckStatus(object? sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            Console.WriteLine($"{name} is in perfect health!");
        }
        else if (e.currentHp >= (maxHp * 0.5) && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} is doing well!");
        }
        else if (e.currentHp >= (maxHp * 0.25) && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} isn't doing too great...");
        }
        else if (e.currentHp > 0 && e.currentHp <= (0.25 * maxHp))
        {
            Console.WriteLine($"{name} needs help!");
        }
        else if (e.currentHp == 0)
        {
            Console.WriteLine($"{name} is knocked out!");
        }
    }

    /// <summary>
    /// Health value warning.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments.</param>
    private void HPValueWarning(object? sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }

    /// <summary>
    /// Checks the status of health.
    /// </summary>
    /// <param name="e">The event arguments.</param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp <= (0.25 * maxHp))
        {
            HPCheck += HPValueWarning;
        }

        HPCheck.Invoke(this, e);
    }

    /// <summary>
    /// Outputs the player's current health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("A Bunch of Angry Eggs", 500f);
        player.PrintHealth();

        player.TakeDamage(1f);
        player.PrintHealth();
    }
}