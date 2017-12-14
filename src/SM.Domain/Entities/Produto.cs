using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            Idf_Produto = Guid.NewGuid();
        }
        public Guid     Idf_Produto                                 { get; set; }
        public String   Des_Nme_Produto                             { get; set; }
        public String   Des_Produto                                 { get; set; }
        public Decimal  Vlr_Produto                                 { get; set; }
        public DateTime Dta_Cadastro                                { get; set; }
        public DateTime? Dta_Alteracao                               { get; set; }
        public Guid     Idf_Anuncio                                 { get; set; }

        public virtual Anuncio Anuncio                              { get; set; }

        public virtual ICollection<Categoria> Categorias            { get; set; }
        public virtual ICollection<ProdutoImagem> ProdutoImagens    { get; set; }
    }
}
