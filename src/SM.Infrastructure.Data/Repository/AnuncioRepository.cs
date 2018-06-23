using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using SM.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SM.Infrastructure.Data.Repository
{
    public class AnuncioRepository : Repository<Anuncio>, IAnuncioRepository
    {
        public AnuncioRepository(SenaMotosContext context)
            : base(context)
        {

        }

        public IEnumerable<Anuncio> ObterPorTituloAnuncio(string titulo)
        {
            return Buscar(a => a.Des_Titulo_Anuncio.Contains(titulo)).OrderBy(a=>a.Des_Titulo_Anuncio).ToList();
        }

        public IEnumerable<Anuncio> ObterPorDescricaoAnuncio(string descricao)
        {
            return Buscar(a => a.Des_Anuncio.Contains(descricao)).OrderBy(a => a.Des_Titulo_Anuncio).ToList();
        }

        public IEnumerable<Anuncio> ObterPorIdAnunciante(Guid id)
        {
            return Buscar(a => a.Idf_Usuario.Equals(id)).OrderBy(a => a.Des_Titulo_Anuncio).ToList();
        }

        public Anuncio ObterPorIdAnuncio(Guid id)
        {
            return Buscar(a => a.Idf_Anuncio.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<Anuncio> ObterPorLoginAnunciante(string login)
        {
            return Buscar(a => a.Usuario.Eml_Usuario.Equals(login)).OrderBy(a => a.Des_Titulo_Anuncio).ToList();
        }
    }
}
