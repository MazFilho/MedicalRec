using MedicalRec.Dominio.Contratos;
using MedicalRec.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace MedicalRec.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        // Pegando a instancia (DbContext) criada pela propria infra do asp net core (configure services) e armezanando internamente na classe BaseRepositorio.
        // Conexão das classes com banco de dados, (implementar os metodos d basereositorio) pegando as configurações de DbContext, q são configurads/referenciadas na classe Startup.

        //Armazena internamente instancia recebida da startup.cs (configure service)
        protected readonly MedicalRecContexto MedicalRecContexto;

        //Construtor q recebe instncia de Startup.cs (Configure Service)
        public BaseRepositorio(MedicalRecContexto medicalRecContexto)
        {
            MedicalRecContexto = medicalRecContexto;
        }

        //metodos
        public void Adicionar(TEntity entity)
        {
            MedicalRecContexto.Set<TEntity>().Add(entity);
            MedicalRecContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            MedicalRecContexto.Set<TEntity>().Update(entity);
            MedicalRecContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return MedicalRecContexto.Set<TEntity>().Find(id);
        }

        //Obter por qqr campo
        //public TEntity ObterPorId(TEntity entity)
        //{
        //    return MedicalRecContexto.Set<TEntity>().Find(entity);
        //}

        public IEnumerable<TEntity> ObterTodos()
        {
            return MedicalRecContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            MedicalRecContexto.Remove(entity);
            MedicalRecContexto.SaveChanges();
        }
        public void Dispose()
        {
            MedicalRecContexto.Dispose();
        }
    }
}
