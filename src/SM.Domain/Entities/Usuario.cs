using System;
using System.Collections.Generic;

namespace SM.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            this.Idf_Usuario = Guid.NewGuid();
            //Categorias = new HashSet<Categoria>();
        }

        public Guid     Idf_Usuario                         { get; set; }
        public string   Nme_Usuario                         { get; set; }
        public string   Num_Cpf                             { get; set; }
        public string   Eml_Usuario                         { get; set; }
        public bool     Flg_Inativo                         { get; set; }
        public string   Des_Senha                           { get; set; }
        public string   Des_Senha_Hash                      { get; set; }
        public DateTime Dta_Nascimento                      { get; set; }
        public DateTime Dta_Cadastro                        { get; set; }
        public DateTime? Dta_Alteracao                       { get; set; }

        public virtual Contato Contato                      { get; set; }
        public virtual UsuarioImagem UsuarioImagem          { get; set; }
        public virtual ICollection<Anuncio> Anuncios        { get; set; }   // Quando o Usuário anuncia algo
        public virtual ICollection<Categoria> Categorias    { get; set; }
        public virtual ICollection<Negociacao> Negociacoes  { get; set; }   // Quando o Usuário está interessado em algo
    }
}
