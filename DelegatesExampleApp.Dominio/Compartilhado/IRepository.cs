using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExampleApp.Dominio.Compartilhado
{
    public interface IRepository<T> where T : Entidade
    {
        List<T> registros { get; }
        void Adicionar(T entidade);
        List<T> SelecionarTodos();
        T SelecionarPorId(int id);
    }
}
