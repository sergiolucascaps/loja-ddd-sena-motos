using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class Anuncio
    {
        public Anuncio()
        {
            Idf_Anuncio = Guid.NewGuid();
        }
        public Guid     Idf_Anuncio                     { get; set; }
        public String   Des_Titulo_Anuncio              { get; set; }
        public String   Des_Anuncio                     { get; set; }
        public String   Flg_Inativo                     { get; set; }
        public DateTime Dta_Cadastro                    { get; set; }
        public DateTime? Dta_Alteracao                   { get; set; }
        public Guid     Idf_Usuario                     { get; set; }

        public virtual Usuario Usuario                  { get; set; }
        public virtual ICollection<Produto> Produtos    { get; set; }
        public virtual ICollection<Negociacao> Negociacoes { get; set; }
    }
}
