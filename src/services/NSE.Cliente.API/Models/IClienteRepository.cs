using System.Collections.Generic;
using System.Threading.Tasks;
using NSE.Core.Data;

namespace NSE.Cliente.API.Models
{
    public interface IClienteRepository : IRepository<ClienteLoja>
    {
        void Adicionar(ClienteLoja cliente);

        Task<IEnumerable<ClienteLoja>> ObterTodos();
        Task<ClienteLoja> ObterPorCpf(string cpf);
    }
}