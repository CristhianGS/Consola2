using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaConsola2
{
    class Sucursal
    {
        public int Id { get; set; }
        public string NombreSucur { get; set; }
        public string TelefonoSucur { get; set; }
        public string DirecccionSucur { get; set; }
        public string PaisSucur { get; set; }


        public string Comunicar()
        {
            return $"Puedes comunicarte a nuestra sucursal {NombreSucur} al número {TelefonoSucur} o acarte a nuestras oficinas \nubicadas en {DirecccionSucur}";
        }

    }
}