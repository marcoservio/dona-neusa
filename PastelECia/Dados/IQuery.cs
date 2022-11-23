using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelECia.Dados
{
    internal interface IQuery<T>
    {
        List<T> ListarTodos();
        T ListarPor(int id);
        List<T> ListarPor(string nome);
    }
}
