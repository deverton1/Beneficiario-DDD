using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Domain.Commands
{
    public class BeneficiarioCommand
    {
        public int BeneficiarioId { get; set; }
        public string NomeBeneficiario { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
