using System;
using Pokemon.Controller;
using Pokemon.Model;
using Pokemon.Service;
using Pokemon.View;

public class Program{

    static void Main(string[]args){

        PokemonController controller = new PokemonController();
        controller.Jogar();
   
    }
}