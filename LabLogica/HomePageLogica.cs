using ApiLaboratorio.Models;
using LabDatos;
using System;
using System.Collections.Generic;

namespace LabLogica
{
    public class HomePageLogica
    {
        HomePageDatos hpd = new HomePageDatos();

        public IEnumerable<Carrera> GetCarreras(int accion)
        {
            return hpd.GetCarreras(accion);
        }
    }
}
