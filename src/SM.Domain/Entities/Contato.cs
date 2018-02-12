using System;
using System.Collections.Generic;

namespace SM.Domain.Entities
{
    public class Contato
    {
        public Contato()
        {
            Idf_Contato = Guid.NewGuid();
        }
        
        public Guid     Idf_Contato                     { get; set; }
        public string   Des_Eml_Contato                 { get; set; }
        public DateTime Dta_Cadastro                    { get; set; }
        public DateTime? Dta_Alteracao                   { get; set; }
        public Guid     Idf_Usuario                     { get; set; }

        public virtual Usuario Usuario                  { get; set; }
        public virtual ICollection<Endereco> Enderecos  { get; set; }
        public virtual ICollection<Telefone> Telefones  { get; set; }
    }
}
