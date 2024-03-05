using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon{

    public class PokemonSpecies{
        int Count {get; set;}
        string Next {get; set;}
        string Previous {get; set;}

        public List<PokemonSpecies> especies {get; set;}
    }
    
}