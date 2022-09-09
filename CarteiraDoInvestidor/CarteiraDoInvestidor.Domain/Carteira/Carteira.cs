using CarteiraDoInvestidor.CrossCuting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Domain.Carteira
{
    public class Carteira : Entity<Guid>
    {
        public string Ativo { get; set; }
        public double PrecoMedio { get; set; }
        public string Corretora { get; set; }
    }
}
