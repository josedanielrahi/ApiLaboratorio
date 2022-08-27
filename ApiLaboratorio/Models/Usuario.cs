using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLaboratorio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Rol { get; set; }
        public int Valor { get; set; }
    }
}
