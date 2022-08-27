using System;

namespace LabConsultas
{
    public class HomePageQuery
    {
        public string ContenidoPagina(int accion)
        {
            string sqlQuery = $"EXEC CONTENIDO_PAGINA @ACC = {accion}";
            return sqlQuery;
        }
        public string ContenidoPaginaById(int accion,int valor)
        {
            string sqlQuery = $"EXEC CONTENIDO_PAGINA @ACC = {accion}, @VAL = {valor}";
            return sqlQuery;
        }
    }
}
