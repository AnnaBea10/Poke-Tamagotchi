using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon{
    
    public class PokemonResults{

        string Name {get; set;}
        string Url {get; set;}

        public List<PokemonResults> results {get; set;}
    }
}