using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DelegatesExampleApp.Dominio
{
    public class Aluno : Entidade
    {
        public Aluno(string nome, int turma)
        {
            Nome = nome;
            Turma = turma;
        }

        public string Nome { get; set; }
        public int Turma { get; set; }
    }
}
