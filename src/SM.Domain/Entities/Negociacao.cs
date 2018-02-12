using System;
using System.Collections.Generic;

namespace SM.Domain.Entities
{
    public class Negociacao
    {
        public Negociacao()
        {
            Idf_Negociacao = Guid.NewGuid();
        }
        public Guid     Idf_Negociacao                      { get; set; }
        public string   Des_Negociacao                      { get; set; }
        public int      Idf_Status_Negociacao               { get; set; }
        public DateTime Dta_Inicio_Negociacao               { get; set; }
        public DateTime Dta_Fim_Negociacao                  { get; set; }
        public Guid     Idf_Anuncio                         { get; set; }
        public Guid     Idf_Usuario                         { get; set; }   // Este é o IDF do Usuario INTERESSADO na no Produto. O Do Anunciante estará presente no anúncio.

        public virtual Anuncio Anuncio                      { get; set; }
        public virtual Usuario Usuario                      { get; set; }
        public virtual Venda Venda                          { get; set; }
        public virtual ICollection<Chat> Chats              { get; set; }
        public virtual StatusNegociacao StatusNegociacao    { get; set; }
    }
}
