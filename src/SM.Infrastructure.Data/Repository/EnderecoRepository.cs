using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public Endereco ObterEnderecoPorIdContato(Guid id)
        {
            return Buscar(e => e.Idf_Contato.Equals(id)).FirstOrDefault();
        }
    }
}
