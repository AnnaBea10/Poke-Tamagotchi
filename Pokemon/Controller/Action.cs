using System;
using System.Text.Json.Serialization;
using RestSharp;
using Newtonsoft.Json;

using RestSharp.Authenticators;
using System.Text.Json.Nodes;
using Microsoft.VisualBasic;
using System.Collections;


namespace Pokemon{

    public class Action{

        private Menu menu {get; set;}
        private ApiService service {get; set;}
        private List<PokemonResults> especiesDisponiveis {get; set;}

        private List<PokemonDetailsResults> mascotesAdotados {get; set;}

        public Action(){
        menu = new Menu();
        service = new ApiService();
        especiesDisponiveis = service.ObterEspeciesPokemon();
        mascotesAdotados = new List<PokemonDetailsResults>();
        }


        public void Jogar(){
            menu.MostrarMensagemDeBoasVindas();
    
        while(true)
        {
            menu.MostrarMenuPrincipal();
            int escolha = menu.ObterEscolhaJogador();
            
            switch(escolha)
            {
                case 1:
                while(true)
                {
                    menu.MostrarMenuAdocao();
                    escolha = menu.ObterEscolhaJogador();
                    switch(escolha)
                    {
                        case 1:
                        menu.MostrarEspeciesDisponiveis(especiesDisponiveis);
                        break;

                        case 2:
                        menu.MostrarEspeciesDisponiveis(especiesDisponiveis);
                        int indiceEspecies = menu.ObterMascoteEscolhido(especiesDisponiveis);
                        PokemonDetailsResults detalhes = service.ObterDetalhesEspecies(especiesDisponiveis[indiceEspecies]);
                        menu.MostrarOpcoesDetalhes(detalhes);
                        break;

                        case 3:
                        menu.MostrarEspeciesDisponiveis(especiesDisponiveis);
                        indiceEspecies = menu.ObterMascoteEscolhido(especiesDisponiveis);
                        detalhes = service.ObterDetalhesEspecies(especiesDisponiveis[indiceEspecies]);menu.MostrarOpcoesDetalhes(detalhes);
                        if(menu.AdotarMascote()){
                            mascotesAdotados.Add(detalhes);
                            Console.WriteLine("Parabéns! Você adotou um " + detalhes.Name + "!");
                                        Console.WriteLine("──────────────");
                                        Console.WriteLine("────▄████▄────");
                                        Console.WriteLine("──▄████████▄──");
                                        Console.WriteLine("──██████████──");
                                        Console.WriteLine("──▀████████▀──");
                                        Console.WriteLine("─────▀██▀─────");
                                        Console.WriteLine("──────────────");
                        }
                        break;
                        case 4:
                        break;
                    }
                    if(escolha == 4){
                        break;
                    }
                }
                break;

                case 2:
                menu.MostarMascotesAdotados(mascotesAdotados);
                break;

                case 3:
                Console.WriteLine("Obrigado por jogar! Até a próxima = ) ");
                return;
            }
            }
        }
    }
}
