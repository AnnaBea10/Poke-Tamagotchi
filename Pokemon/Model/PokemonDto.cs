using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pokemon.Model{

    public class PokemonDto{

        public int Alimentacao {get; private set;}
        public int Saude {get; private set;}
        public int Energia {get; private set;}
        public int Humor {get; private set;}
        public int Altura {get; set;}
        public int Peso {get; set;}
        public string Nome {get; set;}
        public List<Habilidade> Habilidades {get; set;}

    public PokemonDto()
    {
        var rand = new Random();
        Alimentacao = rand.Next(11);
        Saude = rand.Next(11);
        Energia = rand.Next(11);
        Humor = rand.Next(11);
    }

    public void Alimentar(){
        Alimentacao = Math.Min(Alimentacao + 2, 10);
        Energia = Math.Max(Energia - 1, 0);

        Console.WriteLine("Mascote Alimentado!");
    }

    public void Brincar(){
        Humor = Math.Min(Humor +3, 10);
        Energia = Math.Max (Energia -1, 0);
        Alimentacao = Math.Max( Alimentacao -1, 0);

        Console.WriteLine("Mascote Feliz!");
    }

    public void Descansar(){
        Humor = Math.Min (Humor +3, 10);
        Energia = Math.Max (Energia -1, 0);

        Console.WriteLine("Mascote dormindo!");
    }

    public void DarCarinho(){
        Humor = Math.Min(Humor +3, 10);
        Saude = Math.Max(Saude +1, 0);

        Console.WriteLine("Mascote Amado!");
    }

    public void MostrarStatus(){
        Console.WriteLine("Status do Mascote: ");
        Console.WriteLine($"Alimentacao {Alimentacao}");
        Console.WriteLine($"Humor {Humor}");
        Console.WriteLine($"Energia {Energia}");
        Console.WriteLine($"Saude {Saude}");
    }
  }

    public class Habilidade
    {
        public string Nome {get; set;}
    }
}