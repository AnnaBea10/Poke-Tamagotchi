using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Pokemon;
using RestSharp;


public class Menu{

    public void MostrarMensagemDeBoasVindas(){
        Console.WriteLine("\n --------------------------------");
        Console.WriteLine("Bem-vindo(a) ao jogo de adoção de mascotes!");
        Console.WriteLine("Por favor, digite o seu nome: ");
        string nomeJogador = Console.ReadLine();
        Console.WriteLine("Olá, " + nomeJogador + "! Vamos começar!");
    }

    public void MostrarMenuPrincipal(){
        Console.WriteLine("\n ------------ MENU --------------");
        Console.WriteLine("1. Adotar um mascote virtual");
        Console.WriteLine("2. Ver meus mascotes");
        Console.WriteLine("3. Sair do jogo");
    }

    public int ObterEscolhaJogador(){
        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 4)
        {
            Console.WriteLine("Escolha inválida. Por favor, escolha uma opção entre 1 e 3: ");
        }
        return escolha;
    }

    //Opções do Menu
    public void MostrarMenuAdocao(){
        Console.WriteLine("\n ------- MENU DE ADOÇÃO ---------");
        Console.WriteLine("1. Ver Espécies Disponíveis");
        Console.WriteLine("2. Ver Detalhes de uma Espécie");
        Console.WriteLine("3. Adotar um Mascote");
        Console.WriteLine("4. Voltar ao Menu Principal");
        Console.WriteLine("Escolha uma opção: ");  
    }
    public void MostarMascotesAdotados(List<PokemonDetailsResults> mascotesAdotados){
        Console.WriteLine("\n ----- MASCOTES ADOTADOS -----");   
        if(mascotesAdotados.Count == 0){
            Console.WriteLine("Você ainda não possue mascotes! ");
        }    
        else{
            for(int i = 0; i < mascotesAdotados.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + mascotesAdotados[i].Name);
            }
        }
    }

    //Opções do menu adoção
    public void MostrarEspeciesDisponiveis(List<Pokemon.PokemonResults> especies){
        Console.WriteLine("\n ----- ESPÉCIES DISPONÍVEIS -----");
        for (int i = 0; i < especies.Count; i++ ){
            Console.WriteLine((i + 1) + "." + especies[i].results);
        }
    }

    public void MostrarOpcoesDetalhes(Pokemon.PokemonDetailsResults detalhes){
        Console.WriteLine("\n ----- DETALHES DA ESPÉCIE -----");
        Console.WriteLine("Nome: " + detalhes.Name);
        Console.WriteLine("Ordem: " + detalhes.Order);
        Console.WriteLine("Altura: " + detalhes.Height);
        Console.WriteLine("Peso: " + detalhes.Weight);
        foreach (var habilidades in detalhes.Abilities){
            Console.WriteLine(" - " + habilidades.Ability.Name);

        }
    }

    public bool AdotarMascote(){
        Console.WriteLine("Você deseja adotar este mascoste? (s/n): ");
        string resposta = Console.ReadLine();
        return resposta.ToLower() == "s";
    }

    public int ObterMascoteEscolhido(List<PokemonSpecies> especies ){
        int escolha;
        while(true){
            Console.WriteLine("Escolha uma espécie pelo número ( 1- " + especies.Count + "):");
            if(!int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= especies.Count){
                break;
            }
            Console.WriteLine("Escolha inválida");
        }
        return escolha -1;
        
    }
}