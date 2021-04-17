using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VibeTest.Core.InterfacesGenerics
{
    public interface IApplication<T> : IDisposable where T : IAggregateRoot
    {
        Task<IEnumerable<T>> BuscarTodos(int pagina);
        Task<T> BuscarPorId(int id);
    }
}
