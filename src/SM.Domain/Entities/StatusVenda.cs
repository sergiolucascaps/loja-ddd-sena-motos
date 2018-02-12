using System;

namespace SM.Domain.Entities
{
    public class StatusVenda
    {
        public StatusVenda()
        {

        }
        public int      Idf_Status_Venda    { get; set; } // Campo utilizado para Enumeradores na Aplicação
        public string   Des_Status_Venda    { get; set; }
        public DateTime Dta_Cadastro        { get; set; }

        //public virtual Venda Venda          { get; set; }
    }
}
