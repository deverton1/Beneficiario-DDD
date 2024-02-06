using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string NomeDoador { get; set; }
        public bool Disponivel { get; set; } = false;

    }
}
