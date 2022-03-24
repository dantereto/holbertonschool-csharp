using System;
/// <summary> Player Class </summary>
public delegate float CalculateHealth(float amount);
/// <summary> Player Class </summary>
public class Player
{
    
    private string name {get; set;}
    private float maxHp {get; set;}
    private float hp {get; set;}
    /// <summary> Player Class </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    /// <summary> Player Class </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
    /// <summary> Player Class </summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
    }
    /// <summary> Player Class </summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }
    /// <summary> Player Class </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        if (newHp >= maxHp)
            this.hp = maxHp;
        else
            this.hp = newHp;
    }
}
