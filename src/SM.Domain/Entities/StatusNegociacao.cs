using System;

namespace SM.Domain.Entities
{
    public class StatusNegociacao
    {
        public StatusNegociacao()
        {
        }
        public int      Idf_Status_Negociacao   { get; set; }// Campo utilizado para Enumeradores na Aplicação
        public string   Des_Status_Negociacao   { get; set; }
        public DateTime Dta_Cadastro            { get; set; }
    }
}
