using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Command
{
    public class CreateCarteiraCommand : IRequest<CreateCarteiraCommandResponse>
    {
        public CarteiraInputDto Carteira { get; set; }

        public CreateCarteiraCommand(CarteiraInputDto carteira)
        {
            Carteira = carteira;
        }
    }

    public class CreateCarteiraCommandResponse
    {
        public CarteiraOutputDto Carteira { get; set; }

        public CreateCarteiraCommandResponse(CarteiraOutputDto carteira)
        {
            Carteira = carteira;
        }
    }
}
