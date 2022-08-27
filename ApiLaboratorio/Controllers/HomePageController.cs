using ApiLaboratorio.Models;
using LabConsultas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLaboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        controLaboratorioContext dbContext = new controLaboratorioContext();
        HomePageQuery hpq = new HomePageQuery();

        [HttpGet("carreras")]
        public IEnumerable<Carrera> GetCarreras()
        {
            return dbContext.Carreras.FromSqlRaw<Carrera>(hpq.ContenidoPagina(1))
                                     .ToList();
        }
        [HttpGet("carreras/{id:int}")]
        public IEnumerable<Carrera> GetCarrera(int id)
        {
            return dbContext.Carreras.FromSqlRaw<Carrera>(hpq.ContenidoPaginaById(2,id))
                                     .ToList();
        }

        [HttpGet("edificios")]
        public IEnumerable<Edificio> GetEdificio()
        {
            return dbContext.Edificios.FromSqlRaw<Edificio>(hpq.ContenidoPagina(3))
                            .ToList();
        }
        [HttpGet("edificios/{id:int}")]
        public IEnumerable<Edificio> GetEdificio(int id)
        {
            return dbContext.Edificios.FromSqlRaw<Edificio>(hpq.ContenidoPaginaById(4,id))
                            .ToList();
        }

    }
}
