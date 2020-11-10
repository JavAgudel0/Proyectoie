using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyectoie.Web.Data;
using Proyectoie.Web.Data.Entities;

namespace Proyectoie.Web.Controllers
{
    public class SucursalesController : Controller
    {
        private readonly DataContext _context;

        public SucursalesController(DataContext context)
        {
            _context = context;
        }

        // GET: Sucursales
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sucursales.ToListAsync());
        }

        // GET: Sucursales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sucursalEntidad = await _context.Sucursales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sucursalEntidad == null)
            {
                return NotFound();
            }

            return View(sucursalEntidad);
        }

        // GET: Sucursales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Prefijo,Direccion,Telefono")] SucursalEntidad sucursalEntidad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sucursalEntidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sucursalEntidad);
        }

        // GET: Sucursales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sucursalEntidad = await _context.Sucursales.FindAsync(id);
            if (sucursalEntidad == null)
            {
                return NotFound();
            }
            return View(sucursalEntidad);
        }

        // POST: Sucursales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Prefijo,Direccion,Telefono")] SucursalEntidad sucursalEntidad)
        {
            if (id != sucursalEntidad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sucursalEntidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SucursalEntidadExists(sucursalEntidad.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sucursalEntidad);
        }

        // GET: Sucursales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sucursalEntidad = await _context.Sucursales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sucursalEntidad == null)
            {
                return NotFound();
            }

            return View(sucursalEntidad);
        }

        // POST: Sucursales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sucursalEntidad = await _context.Sucursales.FindAsync(id);
            _context.Sucursales.Remove(sucursalEntidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SucursalEntidadExists(int id)
        {
            return _context.Sucursales.Any(e => e.Id == id);
        }
    }
}
