using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.Domain.Carteira;

namespace CarteiraDoInvestidor.Application.Carteira.Profile
{
    public class CarteiraProfile : AutoMapper.Profile
    {
        public CarteiraProfile()
        {
          
            CreateMap<Ativos, AtivosOutputDto>();

            CreateMap<AtivosInputDto, Ativos> ();

            CreateMap<CarteiraInputDto, CarteiraDoInvestidor.Domain.Carteira.Carteira>();

            CreateMap<CarteiraDoInvestidor.Domain.Carteira.Carteira, CarteiraOutputDto>();

            CreateMap<CarteiraUpdateDto, CarteiraDoInvestidor.Domain.Carteira.Carteira>();
        }
    }
}
