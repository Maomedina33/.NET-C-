using System;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json;

public class person
{
    public string Name { get; set; }
    public int Age { get; set; }        
}
class Program
{
    static void Main(string[] args)
    {
        var person = new person
        {
            Name = "John Doe",
            Age = 30
        };


        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine("Serialezed JSON:" + json);

        var deserializedPerson = JsonConvert.DeserializeObject<person>(json);
        Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
    }
}

