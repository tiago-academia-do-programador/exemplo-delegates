using DelegatesExampleApp.Dominio;
using DelegatesExampleApp.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace DelegatesExampleApp.ConsoleApp.ModuloAluno
{
    public class TelaAluno
    {
        protected readonly IRepository<Aluno> _repositorioAluno;

        public TelaAluno(IRepository<Aluno> repositorioAluno)
        {
            _repositorioAluno = repositorioAluno;

            PopularAplicacao();
        }

        private void PopularAplicacao()
        {
            _repositorioAluno.Adicionar(new Aluno("Tiago", 5));
            _repositorioAluno.Adicionar(new Aluno("Rech", 1));
            _repositorioAluno.Adicionar(new Aluno("Pedro Xerife", 3));
            _repositorioAluno.Adicionar(new Aluno("Marcos", 7));
        }

        public void MatricularAluno()
        {
            MostrarTitulo("Matriculando Aluno");

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a turma do Aluno: ");
            int turma = Convert.ToInt32(Console.ReadLine());

            _repositorioAluno.Adicionar(new Aluno(nome, turma));

            Console.WriteLine();

            Console.WriteLine("Aluno cadastrado com sucesso!");

            Console.WriteLine();

            Console.ReadLine();
        }


        public void VisualizarTodos()
        {
            MostrarTitulo("Visualizando Alunos");

            Console.WriteLine();

            List<Aluno> alunos = _repositorioAluno.SelecionarTodos();

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Turma: " + aluno.Turma);

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public void VisualizarTodosDecrescente()
        {
            MostrarTitulo("Visualizando Alunos");

            Console.WriteLine();

            List<Aluno> alunos = _repositorioAluno.SelecionarTodos();

            List<Aluno> alunosOrdenados = new List<Aluno>(alunos);

            alunosOrdenados.Sort( (Aluno a, Aluno b) => b.Turma.CompareTo(a.Turma));

            foreach (Aluno aluno in alunosOrdenados)
            {
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Turma: " + aluno.Turma);

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public void VisualizarAluno()
        {
            MostrarTitulo("Visualizando Aluno");

            Console.Write("Digite o id do Aluno a ser selecionado: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Aluno alunoSelecionado = _repositorioAluno.SelecionarPorId(id);

            Console.WriteLine("Numero: " + alunoSelecionado.numero);
            Console.WriteLine("Nome: " + alunoSelecionado.Nome);
            Console.WriteLine("Turma: " + alunoSelecionado.Turma);

            Console.ReadLine();
        }

        private static void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public string MostrarOpcoes()
        {
            string opcaoSelecionada;

            Console.WriteLine("Menu: ");

            Console.WriteLine();

            Console.WriteLine("1 - Matricular Aluno");
            Console.WriteLine("2 - Visualizar Alunos");
            Console.WriteLine("3 - Visualizar Alunos de Forma Ordenada");
            Console.WriteLine("4 - Visualizar Aluno");

            Console.WriteLine();

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }
    }
}
