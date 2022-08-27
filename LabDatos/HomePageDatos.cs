using System.Collections.Generic;
using System.Linq;
using ApiLaboratorio.Models;
using Microsoft.EntityFrameworkCore;

namespace LabDatos
{
    public class HomePageDatos
    {
        controLaboratorioContext dbContext = new controLaboratorioContext();
        public IEnumerable<Carrera> GetCarreras(int accion)
        {
            return dbContext.Carreras.FromSqlRaw<Carrera>($"EXEC ContenidoPagina @ACCION = {accion}")
                                     .ToList();
        }
    }
}
