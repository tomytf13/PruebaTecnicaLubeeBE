using APIColegio.Managers.Interfaces;
using APIColegio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIColegio.Controllers
{
    [ApiController]
    [Route("/api")]
    public class SupportController : Controller
    {
        private readonly ISupportManager _supportManager;

        public SupportController(ISupportManager supportManager)
        {
            _supportManager = supportManager;
        }

        /// <summary>
        /// Get Pedido by ID.
        /// </summary>
        /// <param name="id"</param>
        /// <returns> A pedido that contain Items and Contratos.</returns>
        [HttpGet("contrato")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Contrato> GetContrato([FromQuery] int id) 
        { 
            if(id == null) 
            {
                return BadRequest(JsonSerializer.Serialize(new ApiError
                {
                    Code = 400,
                    Message = "No existe un pedido con ese id"
                }));
            }

            try
            {
                var contrato = _supportManager.GetContratoConPedidos(id);
                if (contrato == null)
                {
                    return NotFound(JsonSerializer.Serialize(new ApiError
                    {
                        Code = 404,
                        Message = $"No se encontro ningun contrato con el ID {id}"
                    }));
                }

                return contrato;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
