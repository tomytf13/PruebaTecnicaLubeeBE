using APIColegio.Models;

namespace APIColegio.Managers.Interfaces
{
    public interface ISupportManager
    {
        public Contrato GetContratoConPedidos(int id);
    }
}
