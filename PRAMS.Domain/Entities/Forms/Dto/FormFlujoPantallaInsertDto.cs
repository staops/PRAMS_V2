namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFlujoPantallaInsertDto
    {
        public required int FormularioId { get; set; }
        public required int FormaId { get; set; }
        public required int OrdenEtapa { get; set; }
        public required string FlujoEtapa { get; set; }
        public DateTime FechaFlujo { get; set; } = DateTime.Now;
        public string? UsuarioFlujoId { get; set; }

        /// <summary>
        /// Campo RMO este es el número de referido, hay que determinar cómo estos son 
        /// generados para automatizarlos y que sean secuenciales. Estos deben estar 
        /// basados en la región y lugar según entendemos por lo que estos campos 
        /// puede que sean necesarios al completar el caso para poder generarlo. 
        /// 
        /// Al iniciar el caso no tendremos el numero de Referido de forma inmediata, 
        /// así que estaremos trabajando algunas de las pantallas relacionadas 
        /// como es Personas Link con el numero de ID_Referido que ya lo tenemos 
        /// en la definición de esa tabla de Personas Link.
        /// 
        /// </summary>
        public string? RMO { get; set; }
        public string? NumeroCaso { get; set; }
        public string? Persona { get; set; }
        public string? UsuarioAsignaId { get; set; }
        public string? UsuarioAsignadoId { get; set; }
        public string? FlujoStatus { get; set; }
        public string? Notas { get; set; }
        public string? Comentarios { get; set; }
        public bool EtapaCompletada { get; set; } = false;
        public string? Region { get; set; }
        public string? Local { get; set; }
    }
}
