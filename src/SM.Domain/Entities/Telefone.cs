using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class Telefone
    {
        public Telefone()
        {
            Idf_Telefone = Guid.NewGuid();
        }
        public Guid     Idf_Telefone        { get; set; }
        public string   Num_DDD             { get; set; }
        public string   Num_Telefone        { get; set; }
        public DateTime Dta_Cadastro        { get; set; }
        public DateTime? Dta_Alteracao       { get; set; }
        public Guid     Idf_Contato         { get; set; }

        public virtual Contato Contato      { get; set; }
    }
}
