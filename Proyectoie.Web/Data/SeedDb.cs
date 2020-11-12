using Proyectoie.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoie.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckSucursalesAsync();
        }

        private async Task CheckSucursalesAsync()
        {
            if (!_context.Sucursales.Any())
            {
                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Cali",
                    Prefijo = "CAL",
                    Direccion = "Carrera 6 Nº 22 - 121",
                    Ciudad = "Cali",
                    Telefono = "(2) 489 2226"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Cartagena",
                    Prefijo = "CAR",
                    Direccion = "Transversal 53 Nº 21 - 65 Local 2 y 3",
                    Ciudad = "Cartagena",
                    Telefono = "(5) 693 3329"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Casa del bombillo 3 Pereira",
                    Prefijo = "CB3",
                    Direccion = "Avenida Santander Nº 2E - 46",
                    Ciudad = "Pereira",
                    Telefono = "(6) 340 1363"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Cucuta",
                    Prefijo = "CUC",
                    Direccion = "Avenida Libertadores Nº 3 - 18",
                    Ciudad = "Cucuta",
                    Telefono = "(7) 595 5224"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "Electroindustrial Bucaramanga",
                    Prefijo = "BUC",
                    Direccion = "Carrera 17 Nº 45 - 149",
                    Ciudad = "Bucaramanga",
                    Telefono = "(7) 697 1554"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Eurocircuitos Medellin",
                    Prefijo = "MED",
                    Direccion = "Calle 19A Nº 43B - 50",
                    Ciudad = "Medellín",
                    Telefono = "(4) 604 5889"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Ibague",
                    Prefijo = "IBA",
                    Direccion = "Carrera 5 Nº 26 - 50",
                    Ciudad = "Ibague",
                    Telefono = "(8) 277 1548"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Iluminacion Total Neiva",
                    Prefijo = "NEI",
                    Direccion = "Carrera 5 Nº 4 - 58",
                    Ciudad = "Neiva",
                    Telefono = "(8) 863 1418"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE LumiElectricos Bogota",
                    Prefijo = "LUB",
                    Direccion = "Avenida Caracas Nº 64 - 23",
                    Ciudad = "Bogota",
                    Telefono = "(1) 744 8130"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE LumiElectricos Villavicencio",
                    Prefijo = "LUV",
                    Direccion = "Avenida 40 Nº 27 - 71",
                    Ciudad = "Villavicencio",
                    Telefono = "(8) 684 9675"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Manizales",
                    Prefijo = "MAN",
                    Direccion = "Carerra 23 Nº 46A - 05",
                    Ciudad = "Manizales",
                    Telefono = "(6) 891 8822"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Monteria",
                    Prefijo = "MON",
                    Direccion = "Calle 41 Nº 15E - 34",
                    Ciudad = "Monteria",
                    Telefono = "(4) 789 4691"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Mosquera",
                    Prefijo = "MOS",
                    Direccion = "Carrera 5 Este Nº 20 - 21",
                    Ciudad = "Mosquera",
                    Telefono = "(1) 829 5755"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE NQS Bogota",
                    Prefijo = "NQS",
                    Direccion = "Calle 22b Nº 30 - 32 Puerta 2",
                    Ciudad = "Bogota",
                    Telefono = "(1) 744 8130"
                });

                _context.Sucursales.Add(new SucursalEntidad
                {
                    Nombre = "IE Tamana Ibague",
                    Prefijo = "TAM",
                    Direccion = "Calle 24 Nº 4a - 26",
                    Ciudad = "Ibague",
                    Telefono = "(8) 277 1548"
                });

                await _context.SaveChangesAsync();
            }
        }
    }

}
