using System;

namespace UtilsLibrary
{
    public class Encriptar
    {
        public String EncriptarClave(string cadena)
        {
            string res = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            res = Convert.ToBase64String(encriptar);
            return res;
        }
    }
}
