using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VibeTest.Core.InterfacesGenerics
{
    public interface IApplication<T,U> : IDisposable where T : IAggregateRoot where U : IFilterAggregate
    {
        Task<IEnumerable<T>> BuscarTodos(U parameter);
        Task<T> BuscarPorId(U parameter);
    }
}
