using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IVendaRepository : IRepository<Venda>
    {
        Venda ObterPorIdNegociacao(Guid id);
        Usuario ObterCompradorPorIdVenda(Guid Idf_Negociacao);
        Usuario ObterVendedorPorIdVenda(Guid Idf_Negociacao);
    }
}
