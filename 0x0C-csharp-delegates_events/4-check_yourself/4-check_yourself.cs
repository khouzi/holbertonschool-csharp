using System;

/// <summary>
/// enum for modifier
/// </summary>
public enum Modifier
{
    /// <summary>
    /// weak modifier
    /// </summary>
    Weak,

    /// <summary>
    /// base modifier
    /// </summary>
    Base,

    /// <summary>
    /// strong modifier
    /// </summary>
    Strong
}

/// <summary>
/// delegate for calculating modifier
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// class Player
/// </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    string status;

    /// <summary>
    /// player constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name ="Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
        status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// print health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// delegate for taking damage
    /// </summary>
    /// <param name="number"></param>
    public delegate void CalculateHealth(float number);


    /// <summary>
    /// TakeDamage
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        float Newhp = hp;
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            Newhp = hp - damage;
            Console.WriteLine($"{name} takes {damage} damage!");
        }
        ValidateHP(Newhp);
    }

    /// <summary>
    /// HealDamage
    /// </summary>
    public void HealDamage(float heal)
    {
        float Newhp = hp;
        if (heal < 0f)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            heal = 0f;
        }
        else
        {

            Newhp = hp + heal;
            Console.WriteLine($"{name} heals {heal} HP!");
        }
        ValidateHP(Newhp);

    }

    /// <summary>
    /// validate hp
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            hp = 0f;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
        HPCheck(this, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// apply modifier
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue,  Modifier modifier)
    {
    if (modifier == Modifier.Weak)
        return (baseValue / 2);
    else if (modifier == Modifier.Base)
        return (baseValue);
    else if (modifier == Modifier.Strong)
        return (baseValue * 1.5f);
    else
        return baseValue;
    }

    /// <summary>
    /// Event Handler.
    /// </summary>
    public event  EventHandler<CurrentHPArgs> HPCheck;
    /// <summary>
    /// CheckStatus: method.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">List of arguments.</param>

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = ($"{name} is in perfect health!");
        else if (e.currentHp >= maxHp / 2f )
            status = ($"{name} is doing well!");
        else if (e.currentHp >= maxHp / 4f)
            status = ($"{name} isn't doing too great...");
        else if (e.currentHp > 0)
            status = ($"{name} needs help!");
        else
            status = ($"{name} is knocked out");
        Console.WriteLine(status);
    }

}

/// <summary>
/// class CurrentHPArgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// CurrentHP
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// CurentHPArgs Constructor
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

