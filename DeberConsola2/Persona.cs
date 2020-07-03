using System;
namespace ProgramaConsola2
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        private Empresa empresa;
        public Empresa Empresa
        {
            get { return empresa; }
            set
            {
                empresa = value;
                empresa.Gerente = this;
            }
        }

        public string Presentar()
        {
            return $"Hola me llamo {Nombre} {Apellido} soy {Cargo} de {Empresa.Nombre} producimos {Empresa.Articulo}";
        }
    }
}