using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Localize.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost("Cliente")]
        public async Task<IActionResult> CadastrarCliente(Cliente cliente)
        {
            await _clienteService.CadastrarCliente(cliente);

            return Created($"api/clientes/{cliente.Nome}", cliente);
        }
    }
}
