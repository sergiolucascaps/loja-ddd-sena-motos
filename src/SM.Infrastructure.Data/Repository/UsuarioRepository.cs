using Dapper;
using SM.Domain.Entities;
using SM.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public Usuario ObterPorCpf(string cpf)
        {
            //return Db.Tab_Usuario.FirstOrDefault(u => u.Num_Cpf.Equals(cpf));
            //ou
            return Buscar(u => u.Num_Cpf.Equals(cpf)).FirstOrDefault();
        }
        
        public Usuario ObterPorLogin(string Login)
        {
            //return Db.Tab_Usuario.FirstOrDefault(u => u.Eml_Usuario.Equals(Login));
            //ou
            return Buscar(u => u.Eml_Usuario.Equals(Login)).FirstOrDefault();
        }

        public IEnumerable<Usuario> ObterPorNome(string nome)
        {
            return Buscar(u => u.Nme_Usuario.Contains(nome)).OrderBy(u => u.Nme_Usuario).ToList();
        }

        public override IEnumerable<Usuario> ObterTodos()
        {
            #region Usando Entity Framework

            //return Db.Tab_Usuario.ToList();

            #endregion

            #region Usando Dapper
            
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM Tab_Usuario";
            //return cn.Query<Usuario>(sql).Take(100).Skip(10);
            return cn.Query<Usuario>(sql);

            #endregion
        }

        public override void Remover(Guid id)
        {
            //var objUsuario = new Usuario() { Idf_Usuario = id, Flg_Inativo = true };
            var objUsuario = Buscar(u => u.Idf_Usuario.Equals(id)).FirstOrDefault();
            objUsuario.Flg_Inativo = true;
            Atualizar(objUsuario);
        }
    }
}
