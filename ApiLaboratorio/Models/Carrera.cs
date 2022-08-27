using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

#nullable disable

namespace ApiLaboratorio.Models
{
    public partial class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string UrlImg { get; set; }
    }
}
