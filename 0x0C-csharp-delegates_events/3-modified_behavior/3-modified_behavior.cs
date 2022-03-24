using System;
/// <summary> Player Class </summary>
public delegate float CalculateHealth(float amount);
/// <summary> Player Class </summary>
public enum Modifier
    {
        /// <summary> Player Class </summary>
        Weak,
        /// <summary> Player Class </summary>
        Base,
        /// <summary> Player Class </summary>
        Strong
    }
/// <summary> Player Class </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
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
        ValidateHP(this.hp + heal);
        Console.WriteLine($"{name} heals {heal} HP!");
    }
    /// <summary> Player Class </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        if (newHp > maxHp)
            this.hp = maxHp;
        else
            this.hp = newHp;
    }
    /// <summary> Player Class </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float value = baseValue;
        if (modifier == Modifier.Weak)
            value = baseValue * 0.5f;
        if (modifier == Modifier.Base)
            value = baseValue;
        if (modifier == Modifier.Strong)
            value = baseValue * 1.5f;
        return value;
    }
}
