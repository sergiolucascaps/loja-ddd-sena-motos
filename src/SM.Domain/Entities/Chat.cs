using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Entities
{
    public class Chat
    {
        public Chat()
        {
            Idf_Chat = Guid.NewGuid();
        }
        public Guid Idf_Chat { get; set; }
        public string Des_Mensagem_Chat { get; set; }
        // Depois verificar a necessidade de Inserir um Campo "Flg_Anunciante" pra saber quando a mensagem é do anunciante e quando é do Interessado.
        public DateTime Dta_Cadastro { get; set; }
        public Guid Idf_Negociacao { get; set; }   //  Idf do Usuário Interessado. O Anunciante ja está no anúncio.

        public virtual Negociacao Negociacao { get; set; }
    }
}
