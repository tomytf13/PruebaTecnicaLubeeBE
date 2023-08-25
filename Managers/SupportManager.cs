using APIColegio.Managers.Interfaces;
using APIColegio.Models;
using APIColegio.Repositories.Interfaces;

namespace APIColegio.Managers
{
    public class SupportManager: ISupportManager
    {
        private readonly IPedidosRepository _pedidosRepository;
        public SupportManager(IPedidosRepository pedidosRepository) 
        {
            _pedidosRepository = pedidosRepository;
        }

        public Contrato GetContratoConPedidos(int id)
        {
            return _pedidosRepository.GetContratoConPedidos(id);
        }
    }
}
