

using Microsoft.AspNetCore.Mvc;
using ProjetoErr.Models;
using ProjetoErr.Data;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using ProjetoErr.Models.Enuns;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoErr.Controllers

{

    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly DataContext _context;
        public VeiculosController(DataContext context)
        {
            _context = context;
        }        

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
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

          [HttpPost]
        public async Task<IActionResult> Add(Veiculo novoVeiculo)
        {
            try
            {
                if (novoVeiculo.IdMarca == 0)
                {
                    throw new System.Exception("Informe a Marca");
                }

                await _context.Veiculos.AddAsync(novoVeiculo);
                await _context.SaveChangesAsync();

                return Ok(novoVeiculo.Modelo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


      

        


    }
}

