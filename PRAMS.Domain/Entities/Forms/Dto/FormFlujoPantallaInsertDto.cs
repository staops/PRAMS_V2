namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFlujoPantallaInsertDto
    {
        public FormFlujoPantallaInsertDto() { }
        public FormFlujoPantallaInsertDto (int formularioId, int formaId, int ordenEtapa, string flujoEtapa, DateTime fechaFlujo, string? usuarioFlujoId, string? rmo, string? numeroCaso, string? persona, string? usuarioAsignaId, string? usuarioAsignadoId, string? flujoStatus, string? notas, string? comentarios, bool etapaCompletada, string? region, string? local)
        {
            FormularioId = formularioId;
            FormaId = formaId;
            OrdenEtapa = ordenEtapa;
            FlujoEtapa = flujoEtapa;
            FechaFlujo = fechaFlujo;
            UsuarioFlujoId = usuarioFlujoId ?? string.Empty;
            RMO = rmo;
            NumeroCaso = numeroCaso;
            Persona = persona;
            FlujoStatus = flujoStatus;
            Notas = notas;
            Comentarios = comentarios;
            EtapaCompletada = etapaCompletada;
            Region = region;
            Local = local;
            UsuarioAsignaId = usuarioAsignaId;
            UsuarioAsignadoId = usuarioAsignadoId;
        }

        public int FormularioId { get; set; }
        public int FormaId { get; set; }
        public int OrdenEtapa { get; set; }
        public string FlujoEtapa { get; set; }
        public DateTime FechaFlujo { get; set; } = DateTime.Now;
        public string UsuarioFlujoId { get; set; } = string.Empty;

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
