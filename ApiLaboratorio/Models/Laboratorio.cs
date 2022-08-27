using System;
using System.Collections.Generic;

#nullable disable

namespace ApiLaboratorio.Models
{
    public partial class Laboratorio
    {
        public int IdLaboratorio { get; set; }
        public string Nombre { get; set; }
        public string UrlImg { get; set; }
        public int FkIdEdifico { get; set; }

        public virtual Edificio FkIdEdificoNavigation { get; set; }
    }
}
