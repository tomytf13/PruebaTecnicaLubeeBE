using APIColegio.Models;

namespace APIColegio.Repositories.Interfaces
{
    public interface IPedidosRepository
    {
        public Contrato GetContratoConPedidos(int id);
    }
}
