using Microsoft.AspNetCore.Mvc;
using ProjetoErr.Models;
using System.Collections.Generic;
using System;
using ProjetoErr.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoErr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasController : ControllerBase
    {
         private readonly DataContext _context;
        public MarcasController(DataContext context)
        {
            _context = context;
        }     

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Marca m = await _context.Marcas.FirstOrDefaultAsync(mBusca => mBusca.IdMarca == id);
                return Ok(m);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
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

        [HttpPost]
        public async Task<IActionResult> Add(Marca novaMarca)
        {
            try
            {
                if (novaMarca.dsMarca == null)
                {
                    throw new System.Exception("Informe a marca");
                }

                await _context.Marcas.AddAsync(novaMarca);
                await _context.SaveChangesAsync();

                return Ok(novaMarca.IdMarca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> update(Marca novaMarca)
        {
            try
            {               
                if (novaMarca.dsMarca == null)
                {
                    throw new System.Exception("Informe a marca");
                }

                _context.Marcas.Update(novaMarca);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Marca mRemover = await _context.Marcas.FirstOrDefaultAsync(m => m.IdMarca  == id);

                _context.Marcas.Remove(mRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}