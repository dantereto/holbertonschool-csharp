using System;

/// <summary> Abstract base class </summary>
public abstract class Base
{
    /// <summary> Abstract base class </summary>
    public string name {get; set;}
    /// <summary> Abstract base class </summary>
    public override string ToString()
    {
        return (String.Format("{0} is a {1}", name, this.GetType().ToString()));
    }
}
    interface IInteractive
    {
        void Interact();
    }
    interface IBreakable{
        int durability {get; set;}
        void Break();
    }
    interface ICollectable{
        bool isCollected {get; set;}
        void Collect();
    }
    
    class Door : Base, IInteractive{
        public Door(string name = "Door")
        {
            this.name = name;
        }
        public void Interact(){
            Console.WriteLine("You try to open the {0}. It's locked.", this.name);
        }
    }
    class Decoration: Base, IInteractive, IBreakable
    {
        public bool isQuestItem;
        public int durability {get; set; }

        public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        if (durability <= 0) {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.isQuestItem = isQuestItem;
        this.durability = durability;
        }
    public void Interact()
    {
        if (durability <= 0) 
            Console.WriteLine("The {0} has been broken.", name);
        else if (isQuestItem == true) 
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else 
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
        
    }
    public void Break() 
    {
        durability--;
        if (durability > 0) 
            Console.WriteLine("You hit the {0}. It cracks.", name);
        if (durability == 0) 
            Console.WriteLine("You smash the {0}. What a mess.", name);
        if (durability < 0) 
            Console.WriteLine("The {0} is already broken.", name);
    }
}
/// <summary> Abstract base class </summary>
public class Key: Base, ICollectable
{
    /// <summary> Abstract base class </summary>
    public bool isCollected {get; set;}
    /// <summary> Abstract base class </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary> Abstract base class </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        if (isCollected == true)
            Console.WriteLine("You have already picked up the {0}.", name);
    }
}