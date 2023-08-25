using APIColegio.Models;
using APIColegio.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APIColegio.Repositories
{
    public class PedidosRepository: IPedidosRepository
    {
        public Contrato GetContratoConPedidos(int contratoId)
        {
            using (var context = new DataBaseContext())
            {
                return context.Contratos
                    .Include(c => c.Pedidos)
                    .ThenInclude(p => p.Item)
                    .FirstOrDefault(c => c.Id == contratoId);
            }
        }




    }
}
