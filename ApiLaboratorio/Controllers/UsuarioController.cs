using ApiLaboratorio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;
using UtilsLibrary;

namespace ApiLaboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        controLaboratorioContext dbContext = new controLaboratorioContext();

        [HttpGet]
        public async Task<ActionResult<int>> NuevoUsuario(Usuario usuario)
        {
            Encriptar en = new Encriptar(); 
              String resultado = en.EncriptarClave(usuario.Clave);

            await dbContext.Database.ExecuteSqlInterpolatedAsync
                ($"EXEC MANEJA_USUARIOS @ACCION = {4}, @USR_EMAIL = {usuario.Email}, @USR_PSW = {resultado}");

            return Ok(1);
        }

    }
}
