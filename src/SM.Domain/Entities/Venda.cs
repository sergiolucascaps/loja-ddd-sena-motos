using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class Venda
    {
        public Venda()
        {
            Idf_Venda = Guid.NewGuid();
        }
        public Guid     Idf_Venda               { get; set; }
        public int      Qtd_Produtos            { get; set; }
        public decimal  Vlr_Final_Venda         { get; set; }
        public DateTime Dta_Cadastro            { get; set; }
        public int      Idf_Status_Venda        { get; set; }
        public Guid     Idf_Negociacao          { get; set; }

        public virtual Negociacao Negociacao    { get; set; }
        public virtual StatusVenda StatusVenda  { get; set; }
        public virtual Entrega Entrega          { get; set; }
    }
}
