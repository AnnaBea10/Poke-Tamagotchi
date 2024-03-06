using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon{

    public class PokemonSpeciesResults{
        int Count {get; set;}
        string Next {get; set;}
        string Previous {get; set;}

        public List<PokemonResults> Results {get; set;}
    }
    
}