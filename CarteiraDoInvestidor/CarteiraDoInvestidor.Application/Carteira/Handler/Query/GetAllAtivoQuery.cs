using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Query
{
    public class GetAllAtivoQuery : IRequest<GetAllAtivoQueryResponse>
    {

    }

    public class GetAllAtivoQueryResponse
    {
        public IList<AtivosOutputDto> Ativoss { get; set; }

        public GetAllAtivoQueryResponse(IList<AtivosOutputDto> ativos)
        {
            Ativoss = ativos;
        }
    }
}
