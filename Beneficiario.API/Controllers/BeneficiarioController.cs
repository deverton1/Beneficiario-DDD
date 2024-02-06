using Beneficiario.Domain.Commands;
using Beneficiario.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Beneficiario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly BeneficiarioService _beneficiarioService;

        public BeneficiarioController(BeneficiarioService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }
        [HttpGet]
        [Route("GetAllBeneficiarios")]
        public async Task<IEnumerable<BeneficiarioCommand>> GetBeneficiariosAsync()
        {
            return await _beneficiarioService.GetBeneficiariosAsync();
        }

    }
}
