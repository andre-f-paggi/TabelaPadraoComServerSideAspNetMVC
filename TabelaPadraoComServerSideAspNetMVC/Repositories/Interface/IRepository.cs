using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TabelaPadraoComServerSideAspNetMVC.Repositories.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        dynamic Adicionar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        bool Atualizar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        bool Deletar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        TEntity ObterPorId(int id, IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> ObterTodos(IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> ObterTodosPaginado(int pageNum, int pageSize, IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> ObterPor(object where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> ObterPaginadoPor(int pageNum, int pageSize, object where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null);
    }
}