using System;
using System.Collections.Generic;

#nullable disable

namespace ApiLaboratorio.Models
{
    public partial class Edificio
    {
        public Edificio()
        {
            Laboratorios = new HashSet<Laboratorio>();
        }

        public int IdEdificio { get; set; }
        public string Nombre { get; set; }
        public string UrlImg { get; set; }

        public virtual ICollection<Laboratorio> Laboratorios { get; set; }
    }
}
