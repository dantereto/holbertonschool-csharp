using System;

abstract class Base
{
    public string name {get; set;}
    
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