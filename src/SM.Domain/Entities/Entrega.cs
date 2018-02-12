using System;

namespace SM.Domain.Entities
{
    public class Entrega
    {
        public Entrega()
        {
            Idf_Entrega = Guid.NewGuid();
        }
        public Guid     Idf_Entrega                 { get; set; }
        public string   Des_Iteracao_Entrega        { get; set; }
        public DateTime Dta_Cadastro                { get; set; }
        public int      Idf_Status_Entrega          { get; set; }
        public Guid     Idf_Venda                   { get; set; }

        public virtual Venda Venda                  { get; set; }
        public virtual StatusEntrega StatusEntrega  { get; set; }
    }
}
