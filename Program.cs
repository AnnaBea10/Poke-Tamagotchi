using System;
using System.Text.Json.Serialization;
using RestSharp;
using Newtonsoft.Json;

using RestSharp.Authenticators;
using System.Text.Json.Nodes;

public class Program{

    static void Main(string[]args){

        var client = new RestClient("https://pokeapi.co/api/v2/");
        var resquest = new RestRequest( "pokemon-species/" ,Method.Get);
        RestResponse response = client.Execute(resquest);

        Console.WriteLine(response.Content);
    }
}