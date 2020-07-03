using System;

namespace ProgramaConsola2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Deber de Consola 2";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            var random = new Random();
            var cocaCola = new Empresa
            {
                Id = random.Next(),
                Nombre = "Coca-Cola",
                Direccion = "Quito-Ecuador",
                Articulo = "gaseosas",
                TasaProduccion = 1200000
            };


            var gerente = new Persona
            {
                Id = random.Next(),
                Nombre = "James",
                Apellido = "Quincey",
                Cargo = "Presidente Mundial",
                Empresa = cocaCola
            };

            var gaseosa = cocaCola.CrearGaseosa("Coca-Cola");


            var sucursal = new Sucursal
            {
                Id = random.Next(),
                NombreSucur = "Arca Cola-Cola",
                DirecccionSucur = "Quito-Ecuador",
                PaisSucur = "Ecuador",
                TelefonoSucur = "(02) 401-2200"

            };

            Console.WriteLine(gerente.Presentar());
            Console.WriteLine(cocaCola.Producir());
            Console.WriteLine(sucursal.Comunicar());
            Console.WriteLine(gaseosa.AbrirTapa());
            Console.WriteLine(gaseosa.Info());
            Console.ReadKey();
        }
    }
}