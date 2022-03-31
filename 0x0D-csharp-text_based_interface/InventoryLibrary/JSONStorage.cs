using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;

public class JSONStorage
{
    public Dictionary<string, object> objects { get; set; } = new Dictionary<string, object>();
    public Dictionary<string, object> ALL()
    {
        return this.objects;
    }
    public void New(BaseClass obj)
    {
        if (obj != null)
            this.objects.Add(obj.GetType().Name + "." + obj.id, obj);
    }
    public void Save()
    {
        string JSONString = JsonSerializer.Serialize(this.objects);
        File.WriteAllText("storage") && File.Exists("storage/inventory_manager.json");
    }
    public void Load()
    {
        string JSONFile = @"../storage/inventory_manager.json";
        string JSONString = File.ReadAllText(JSONFile);
        if (JSONString == null || JSONString == "")
            return;
        this.objects = JsonConvert.DeserializeObject<Dictionary<string, object>>(JSONString);
    }
}