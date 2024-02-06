using Beneficiario.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Domain.Interfaces
{
    public interface IBeneficiarioRepository
    {
        Task<IEnumerable<BeneficiarioCommand>> GetBeneficiariosAsync();
    }
}
