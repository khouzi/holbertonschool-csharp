using System;


/// <summary>
/// class Player
/// </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

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
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
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
    }
}