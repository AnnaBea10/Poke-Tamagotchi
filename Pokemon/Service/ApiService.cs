using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using RestSharp;

namespace Pokemon{

    public class ApiService{

        public List<PokemonResults> ObterEspeciesPokemon(){
            try{

            var client = new RestClient("https://pokeapi.co/api/v2/");
            var resquest = new RestRequest("pokemon-species/" , Method.Get);
            RestResponse response = client.Execute(resquest);

            var pokemonEspeciesResposta = JsonConvert.DeserializeObject<PokemonSpeciesResults>(response.Content);

            if(response.IsSuccessful){
                return pokemonEspeciesResposta.Results;
            }
            Console.WriteLine($"Erro ao obter espécies: {response.Content}");            
            return null;
        } 
        
            catch(HttpRequestException e)
            {
                Console.WriteLine($"Erro ao realizar a requisição: {e.Message}");
                return null;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
                return null;
            }
        }


        public PokemonDetailsResults ObterDetalhesEspecies(PokemonResults especies){
            try{
                           
            var client = new RestClient($"https://pokeapi.co/api/v2/");
            var resquest = new RestRequest("pokemon-species/{especie.Name}", Method.Get);
            var response = client.Execute(resquest);
            
            if (response.IsSuccessful){
                return JsonConvert.DeserializeObject<PokemonDetailsResults>(response.Content);            
            }
            Console.WriteLine($"Erro ao obter detalhes da espécie: {response.Content}");
            return null;
            }

            catch (HttpRequestException e){
                Console.WriteLine($"Erro ao realizar a requisição: {e.Message}");
                return null;
            }
            catch(Exception e){
                Console.WriteLine($"Erro inesperado: {e.Message}");
                return null;
            }
        }        
    }
}