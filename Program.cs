using System;
using System.Text.Json.Serialization;
using RestSharp;
using Newtonsoft.Json;

using RestSharp.Authenticators;
using System.Text.Json.Nodes;
using Microsoft.VisualBasic;

public class Program{

    static void Main(string[]args){

        Menu menu = new Menu();

        menu.MostrarMenuAdoção()

        /*
        Mascote mascote = JsonConvert.DeserializeObject<Mascote>(response.Content);
        Console.WriteLine($"Nome do Mascote: {mascote.Name}");
        Console.WriteLine($"Ordem: {mascote.Order}");
        Console.WriteLine($"Altura: {mascote.Height}");
        Console.WriteLine($"Peso: {mascote.Weight}");
        Console.WriteLine($"Habilidades:");
        foreach (var ability in mascote.Abilities)
        {
            Console.WriteLine($"- {ability.Ability.Name} (Slot: {ability.Slot}, IsHidden: {ability.IsHidden})");    
        }*/    
    }
}