using CarteiraDoInvestidor.Application.Carteira.Dto;

namespace CarteiraDoInvestidor.Application.Carteira.Profile
{
    public class CarteiraProfile : AutoMapper.Profile
    {
        public CarteiraProfile()
        {
          
            CreateMap<CarteiraDoInvestidor.Domain.Carteira.Ativos, AtivosOutputDto>();

            CreateMap<AtivosInputDto, CarteiraDoInvestidor.Domain.Carteira.Ativos> ();

            CreateMap<CarteiraInputDto, CarteiraDoInvestidor.Domain.Carteira.Carteira>();

            CreateMap<CarteiraDoInvestidor.Domain.Carteira.Carteira, CarteiraOutputDto>();

            CreateMap<CarteiraUpdateDto, CarteiraDoInvestidor.Domain.Carteira.Carteira>();
        }
    }
}
