using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class Categoria
    {
        public Categoria()
        {
            Idf_Categoria = Guid.NewGuid();
            //Usuarios = new HashSet<Usuario>();
        }

        public Guid     Idf_Categoria                   { get; set; }
        public string   Des_Titulo_Categoria            { get; set; }
        public string   Des_Categoria                   { get; set; }
        public DateTime Dta_Cadastro                    { get; set; }
        public DateTime? Dta_Alteracao                   { get; set; }

        public virtual ICollection<Usuario> Usuarios    { get; set; }
        public virtual ICollection<Produto> Produtos    { get; set; }
    }
}
