using System;

namespace SM.Domain.Entities
{
    public class StatusEntrega
    {
        public StatusEntrega()
        {

        }
        public int      Idf_Status_Entrega  { get; set; } // Campo utilizado para Enumeradores na Aplicação
        public string   Des_Status_Entrega  { get; set; }
        public DateTime Dta_Cadastro        { get; set; }
    }
}
