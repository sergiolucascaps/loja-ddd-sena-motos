using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class ProdutoImagem
    {
        public ProdutoImagem()
        {
            Idf_Imagem = Guid.NewGuid();
        }
        public Guid     Idf_Imagem      { get; set; }
        public byte[]   Imagem          { get; set; } // Refatorar
        public DateTime Dta_Cadastro    { get; set; }
        public DateTime? Dta_Alteracao   { get; set; }
        public Guid     Idf_Produto     { get; set; }

        public virtual Produto Produto  { get; set; }
    }
}
