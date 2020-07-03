using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaConsola2
{
    class Empresa
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Articulo { get; set; }

        public float TasaProduccion { get; set; }
        public Persona Gerente { get; set; }

        public List<Gaseosa> Gaseosas { get; set; }


        public Gaseosa CrearGaseosa()
        {
            return CrearGaseosa("Coca-Cola");
        }

        public Gaseosa CrearGaseosa(string nombre)
        {
            var nuevaGaseosa = new Gaseosa
            {
                Nombre = nombre,
                Envase = new Envase
                {
                    TipoEnvase = TipoEnvase.BotellaPlastico,
                    Material = "Plastico",
                    Id = new Random().Next(),

                },
                EmpresaProductora = this
            };



            return nuevaGaseosa;
        }

        public string Producir()
        {
            return $"Las máquinas de la empresa producen {TasaProduccion} botellas por minuto , están hechas de {TipoEnvase.BotellaPlastico}";
        }


    }
}


