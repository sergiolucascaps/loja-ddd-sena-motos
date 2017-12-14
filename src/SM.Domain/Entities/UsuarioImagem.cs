using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class UsuarioImagem
    {
        public UsuarioImagem()
        {
            Idf_Imagem = Guid.NewGuid();
        }
        public Guid     Idf_Imagem          { get; set; }
        public string   Imagem              { get; set; } // Refatorar
        public DateTime Dta_Cadastro        { get; set; }
        public DateTime? Dta_Alteracao       { get; set; }
        public Guid     Idf_Usuario         { get; set; }

        public virtual Usuario Usuario      { get; set; }
    }
}
