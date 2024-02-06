using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Repository.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        //to do finalizar banco de dados
        public Task<IEnumerable<BeneficiarioCommand>> GetBeneficiariosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
