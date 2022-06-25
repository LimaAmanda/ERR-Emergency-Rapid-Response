using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoErr.Models;
using ProjetoErr.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoErr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

         public EventosController(DataContext context)
        {
            _context = context;
        } 

        [HttpGet("IdMarcas")]
        public async Task<IActionResult> IdMarcas()
        {
            try
            {
                List<Marca> Lista = await _context.Marcas.ToListAsync();
                return Ok(Lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpGet("IdVeiculos")]
        public async Task<IActionResult> IdVeiculos()
        {
            try
            {
                List<Veiculo> Lista = await _context.Veiculos.ToListAsync();
                return Ok(Lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }  

         [HttpGet("IdUsuarios")]
        public async Task<IActionResult> IdUsuarios()
        {
            try
            {
                List<Usuario> Lista = await _context.Usuarios.ToListAsync();
                return Ok(Lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpPost]
        public async Task<IActionResult> Add(Evento novoEvento)
        {
            try
            {
                if (novoEvento.IdVeiculo == 0)
                {
                    throw new System.Exception("Informe a Marca");
                }

                await _context.Eventos.AddAsync(novoEvento);
                await _context.SaveChangesAsync();

                return Ok(novoEvento.IdUsuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }   

        
    }
}