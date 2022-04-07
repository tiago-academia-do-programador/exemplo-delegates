using DelegatesExampleApp.Dominio;
using DelegatesExampleApp.Dominio.Compartilhado;
using System;
using System.Collections.Generic;


namespace DelegatesExampleApp.Infra.Data.Repositorios
{
    public class AlunoRepository : IRepository<Aluno>
    {
        public List<Aluno> registros { get; }
        private int numeroRegistro;

        public AlunoRepository()
        {
            registros = new List<Aluno>();
        }

        public void Adicionar(Aluno entidade)
        {
            entidade.numero = ++numeroRegistro;

            registros.Add(entidade);
        }

        public List<Aluno> SelecionarTodos()
        {
            return registros;
        }

        public Aluno SelecionarPorId(int id)
        {
            return registros.Find(x => x.numero == id);
        }

    }
}
