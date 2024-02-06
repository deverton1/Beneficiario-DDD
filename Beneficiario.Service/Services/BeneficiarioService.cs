using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Service.Service
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IBeneficiarioService _beneficiarioService;

        public BeneficiarioService(IBeneficiarioService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }

        public async Task<IEnumerable<BeneficiarioCommand>> GetBeneficiariosAsync()
        {
            return await _beneficiarioService.GetBeneficiariosAsync();
        }
    }
}
