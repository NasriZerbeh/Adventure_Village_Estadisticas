using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas.Reportes_y_Validaciones
{
    class Validaciones
    {

        public bool NoCamposVacios(string Cadena)
        {
            Cadena = Cadena.Trim();
            if (Cadena == "" || string.IsNullOrEmpty(Cadena)) return false;
            return true;
        }

        public bool RangoCaracteres(string Cadena, int Min, int Max)
        {
            Cadena = Cadena.Trim();
            if (Cadena.Length < Min || Cadena.Length > Max) return false;
            return true;
        }

        public bool SoloString(string Cadena)
        {
            string Letras = @"^[a-zA-Z]+$";
            Cadena = Cadena.Trim();
            if (Regex.IsMatch(Cadena, Letras)) return true;
            return false;
        }

        public bool SoloInt(string Cadena)
        {
            string Numeros = @"^[1-9]+$";
            Cadena = Cadena.Trim();
            if (Regex.IsMatch(Cadena, Numeros)) return true;
            return false;
        }

        public bool StringNumber(string Cadena)
        {
            string Letras = @"^[a-zA-Z0-9]+$";
            Cadena = Cadena.Trim();
            if (Regex.IsMatch(Cadena, Letras)) return true;
            return false;
        }

        public bool CorreoEmail(string Cadena)
        {
            string EmailFormat = "\\w+([-+.’]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            Cadena = Cadena.Trim();
            if (Regex.IsMatch(Cadena, EmailFormat)) return true;
            return false;
        }

        public bool Contraseña(string Cadena)
        {
            Cadena = Cadena.Trim();
            if (Cadena.Length < 8) return false;
            return true;
        }
        public bool ConfirmarContraseñas(string Cadena1, string Cadena2)
        {
            Cadena1 = Cadena1.Trim();
            Cadena2 = Cadena2.Trim();
            if (Cadena1 == Cadena2) return true;
            return false;
        }
    }
}
