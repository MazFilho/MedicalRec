using MedicalRec.Dominio.Contratos;
using MedicalRec.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace MedicalRec.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly MedicalRecContexto _medicalRecContexto;

        public BaseRepositorio(MedicalRecContexto medicalRecContexto)
        {
            _medicalRecContexto = medicalRecContexto;
        }

        public void Adicionar(TEntity entity)
        {
            _medicalRecContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }               

        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _medicalRecContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
