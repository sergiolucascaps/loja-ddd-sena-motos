using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class VendaRepository : Repository<Venda>, IVendaRepository
    {
        public Usuario ObterCompradorPorIdVenda(Guid id)
        {
            // Também pode resolver o problema(1). Verificar Performance
            //Usuario retorno = (from v in Db.Tab_Venda
            //                   join n in Db.Tab_Negociacao on v.Idf_Negociacao equals n.Idf_Negociacao
            //                   join u in Db.Tab_Usuario on n.Idf_Usuario equals u.Idf_Usuario
            //                   where v.Idf_Venda.Equals(id)
            //                   select u).FirstOrDefault();

            // Também pode resolver o problema(2). Verificar Performance
            //Usuario retorno = Db.Tab_Venda.Where(v => v.Idf_Negociacao == id).Select(v => v.Negociacao.Usuario).FirstOrDefault();

            return Buscar(u => u.Idf_Negociacao.Equals(id)).Select(v => v.Negociacao.Usuario).FirstOrDefault();
        }

        public Venda ObterPorIdNegociacao(Guid id)
        {
            return Buscar(v => v.Idf_Negociacao.Equals(id)).FirstOrDefault();
        }

        public Usuario ObterVendedorPorIdVenda(Guid Idf_Negociacao)
        {
            return Db.Tab_Venda.Where(v => v.Idf_Negociacao.Equals(Idf_Negociacao)).Select(v => v.Negociacao.Anuncio.Usuario).FirstOrDefault();
        }
    }
}
