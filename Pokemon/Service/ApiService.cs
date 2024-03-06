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

            var client = new RestClient("https://pokeapi.co/api/v2/");
            var resquest = new RestRequest("pokemon-species/" , Method.Get);
            RestResponse response = client.Execute(resquest);

            var pokemonEspeciesResposta = JsonConvert.DeserializeObject<PokemonSpeciesResults>(response.Content);

            return pokemonEspeciesResposta.Results;
        } 

        public PokemonDetailsResults ObterDetalhesEspecies(PokemonResults especies){
            var client = new RestClient($"https://pokeapi.co/api/v2/");
            var resquest = new RestRequest("pokemon-species/{especie.Name}", Method.Get);
            var response = client.Execute(resquest);

            return JsonConvert.DeserializeObject<PokemonDetailsResults>(response.Content);
        }
        
    }
}