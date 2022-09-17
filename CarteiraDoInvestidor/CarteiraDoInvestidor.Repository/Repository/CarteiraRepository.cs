using CarteiraDoInvestidor.Domain.Carteira;
using CarteiraDoInvestidor.Domain.Carteira.Repository;
using CarteiraDoInvestidor.Repository.Context;
using CarteiraDoInvestidor.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Repository.Repository
{
    public class CarteiraRepository : Repository<Carteira>, IBandaRepository
    {
        public CarteiraRepository(CarteiraDoInvestidorContext context) : base(context)
        {
        }
    }
}
