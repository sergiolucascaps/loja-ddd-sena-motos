﻿using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Linq;

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
