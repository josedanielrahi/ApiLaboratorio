
using ApiLaboratorio.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaDeDatos
{
    public class HomePage
    {
        controLaboratorioContext dbContext = new controLaboratorioContext();

        public IEnumerable<Carrera> GetCarreras(int accion)
        {
            return dbContext.Carreras.FromSqlRaw<Carrera>($"EXEC ContenidoPagina @ACCION = {accion}")
                                     .ToList();
        }
    }
}
