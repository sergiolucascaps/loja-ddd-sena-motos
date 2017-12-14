using SM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SM.Domain.Interfaces.Repository
{
    public interface IAnuncioRepository : IRepository<Anuncio>
    {
        Anuncio ObterPorIdAnuncio(Guid id);
        IEnumerable<Anuncio> ObterPorIdAnunciante(Guid id);
        IEnumerable<Anuncio> ObterPorLoginAnunciante(string login);
        IEnumerable<Anuncio> ObterPorTituloAnuncio(string titulo);
        IEnumerable<Anuncio> ObterPorDescricaoAnuncio(string descricao);
    }
}
