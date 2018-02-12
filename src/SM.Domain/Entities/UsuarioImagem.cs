using System;

namespace SM.Domain.Entities
{
    public class UsuarioImagem
    {
        public UsuarioImagem()
        {
            //this.Idf_Imagem = Guid.NewGuid();
            //this.Usuario.Idf_Usuario
        }
        //public Guid     Idf_Imagem          { get; set; }
        public string   Imagem              { get; set; }
        public DateTime Dta_Cadastro        { get; set; }
        public DateTime? Dta_Alteracao       { get; set; }
        public Guid     Idf_Usuario         { get; set; }

        public virtual Usuario Usuario      { get; set; }
    }
}
