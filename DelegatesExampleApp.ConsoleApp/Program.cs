using DelegatesExampleApp.ConsoleApp.ModuloAluno;
using DelegatesExampleApp.Infra.Data.Repositorios;
using System;

namespace DelegatesExampleApp.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlunoRepository alunoRepository = new AlunoRepository();
            TelaAluno telaAluno = new TelaAluno(alunoRepository);


            while (true)
            {
                Console.Clear();

                Console.WriteLine("Sistema de Matrículas da Escola");

                Console.WriteLine();

                string opcao = telaAluno.MostrarOpcoes();

                switch (opcao)
                {
                    case "1":
                        telaAluno.MatricularAluno();
                        break;

                    case "2":
                        telaAluno.VisualizarTodos();
                        break;

                    case "3":
                        telaAluno.VisualizarTodosDecrescente();
                        break;

                    case "4":
                        telaAluno.VisualizarAluno();
                        break;
                }
            }
        }

    }
}
