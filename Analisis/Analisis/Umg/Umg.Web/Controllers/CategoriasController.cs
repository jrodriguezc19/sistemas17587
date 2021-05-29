﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;

namespace Umg.Web.Controllers
{
        [Route("api/[controller]")]
        [ApiController]

    public class CategoriasController : ControllerBase 
    {
        private readonly DbContexSistema _context;

        public CategoriasController(DbContexSistema context)
        {
            _context = context;
        }
    

         //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        //GET api/Categorias/2
        [HttpGet ("{idcategoria}")]
        public async Task<ActionResult<Categoria>> GetCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);


            if (categoria == null)
            {
                return NotFound();
            }

            return categoria;
        }

        // api/Categorias/2
        [HttpPut("idcategoria")]
        public async Task<IActionResult>PutCategoria(int id, Categoria categoria)
        
        {
            if(id != categoria.idCategoria)
            {
                return BadRequest();
            }
            //entidad info Save en BD
            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            
            
            catch (DbUpdateConcurrencyException)
             {
             if (!CategoriaExists(id))
                {
                    return NotFound();
             }
            else
            {
                throw;
            }
            }
            return NoContent();
        }
        
        
        //post api/ Categorias
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria); 
            await _context.SaveChangesAsync();

                return CreatedAtAction("GetCategoria", new { id = categoria.idCategoria}, categoria);
        }
        //Delete api/categorias/2
        [HttpDelete("idCategoria")]
        public async Task<ActionResult<Categoria>> DeleteCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
                if(categoria == null)
            {
                return NotFound();
            }
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return categoria;
        }
        private bool CategoriaExists(int id)
        {
            return _context.Categorias.Any(e => e.idCategoria == id);
        }
    }
}