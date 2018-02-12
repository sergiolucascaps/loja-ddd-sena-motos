using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class NegociacaoRepository : Repository<Negociacao>, INegociacaoRepository
    {
        public IEnumerable<Negociacao> ObterPorIdAnuncio(Guid id)
        {
            return Buscar(n => n.Idf_Anuncio.Equals(id)).ToList();
        }

        public IEnumerable<Negociacao> ObterPorIdUsuario(Guid id)
        {
            return Buscar(n => n.Idf_Usuario.Equals(id)).ToList();
        }

        public IEnumerable<Negociacao> ObterPorStatusEUsuario(Guid Idf_Usuario, int Idf_Status_Negociacao)
        {
            return Buscar(n => n.Idf_Usuario.Equals(Idf_Usuario) && n.Idf_Status_Negociacao == Idf_Status_Negociacao).ToList();
        }
    }
}
