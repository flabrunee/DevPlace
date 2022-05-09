using System;
/*USO DE STRUCT https://stackoverflow.com/questions/13049/whats-the-difference-between-struct-and-class-in-net
 *              https://es.stackoverflow.com/questions/336153/una-lista-de-un-arreglo-de-estructuras-c
 *              https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/object-oriented/objects
 *STRING[3] => String.Format("{0:D3}", number); || myString = 3.ToString("D3"); || number.ToString("D3");
 */



namespace Challenge_EjHoras
{
    internal struct Operario
    {
        public string legajo { get; set; }
        public string ap_nom { get; set; }
        public double valorhora { get; set; }
        public double tot_horas_trab { get; set; }
        public double tot_sueldo_a_cobrar { get; set; }
        public DateTime fecha_ult_proc { get; set; }
        public Operario(string legajo, string ap_nom, double valorhora, double THoras, double TotSueldo, DateTime fechaproc)
        {
            this.legajo = legajo;
            this.ap_nom = ap_nom;
            this.valorhora = valorhora;
            this.tot_horas_trab = THoras;
            tot_sueldo_a_cobrar = TotSueldo;
            fecha_ult_proc = fechaproc;
        }
    }
    internal struct Hora_trabajada
    {
        public string legajo { get; set; }
        public double horas_trab { get; set; }
        public Hora_trabajada(string legajo, double horas_trab)
        {
            this.legajo = legajo;
            this.horas_trab = horas_trab;
        }
    }
}