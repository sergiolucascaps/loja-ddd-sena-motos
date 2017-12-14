using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface INegociacaoRepository : IRepository<Negociacao>
    {
        IEnumerable<Negociacao> ObterPorIdAnuncio(Guid id);
        IEnumerable<Negociacao> ObterPorIdUsuario(Guid id);
        IEnumerable<Negociacao> ObterPorStatusEUsuario(Guid Idf_Usuario, int Idf_Status_Negociacao);
    }
}
