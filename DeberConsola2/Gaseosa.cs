namespace ProgramaConsola2
{
    class Gaseosa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long CantidadArticulosVendidos { get; set; }
        public Envase Envase { get; set; }
        public Empresa EmpresaProductora { get; set; }


        public string Info()
        {
            return $"{Nombre} ésta formada por agua carbonatada, azúcar, colorante, acidulante y aromas naturales entre los que se encuentra la cafeína y la vainilla.";
        }

        public string AbrirTapa()
        {
            return $"La tapa se abrió";
        }


    }


}