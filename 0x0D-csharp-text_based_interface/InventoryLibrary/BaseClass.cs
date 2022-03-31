using System;

public class BaseClass
{
    public string id { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }
    public BaseClass()
    {
        this.id = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Trim('=');
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}
