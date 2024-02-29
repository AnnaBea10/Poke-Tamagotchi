using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

internal class Mascote{

    public string Name {get; set;}
    public int Order {get; set;}
    public int Height {get; set;}
    public int Weight {get; set;}

    public List<Abilities> Abilities {get; set;}

}
public class Abilities
{
    public Ability Ability { get; set; }
    public bool IsHidden { get; set; }
    public int Slot { get; set; }
}

public class Ability
{
    public string Name { get; set; }
    public string Url { get; set; }
    
}