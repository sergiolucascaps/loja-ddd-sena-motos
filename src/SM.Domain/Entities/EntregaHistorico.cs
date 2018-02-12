using System;

namespace SM.Domain.Entities
{
    public class EntregaHistorico
    {
        public EntregaHistorico()
        {

        }
        public Guid     Idf_Entrega_Historico           { get; set; }
        public string   Des_Iteracao_Entrega            { get; set; }
        public DateTime Dta_Cadastro                    { get; set; }
        public int      Idf_Status_Entrega              { get; set; }
        public Guid     Idf_Entrega                     { get; set; }

        public virtual Entrega Entrega                  { get; set; }
    }
}
