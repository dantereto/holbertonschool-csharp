public enum Rating
{
    Good,
    Great,
    Excellent
}
public struct Dog{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string nam, float ag, string owne, Rating rat)
    {
        name = nam;
        age = ag;
        owner = owne;
        rating = rat;
    }
    public override string ToString()
   {
      return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
   }
}
