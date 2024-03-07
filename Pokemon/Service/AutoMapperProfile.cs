using System;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Pokemon.Model;

namespace Pokemon.Service{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile(){
            CreateMap<PokemonDetailsResults, PokemonDto>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Peso, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Altura, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.Abilities.Select(a => new Habilidade {Nome = a.Ability.Name})));
        }

        public class MascoteService{
            private readonly IMapper _mapper;

        public MascoteService(IMapper mapper){
            _mapper = mapper;
        
        PokemonDto CriarMascote(PokemonDetailsResults pokemon){
            return _mapper.Map<PokemonDto>(pokemon);
        }
        }
        }
    }
}
