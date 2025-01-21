﻿using Newtonsoft.Json;

namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFormularioFirmaDto
    {

        public int FormularioFirmasId { get; set; }
        public int FormularioId { get; set; }
        public int FormularioEtapaId { get; set; }
        public int? FormaId { get; set; }
        public string? Rmo { get; set; }
        public string NumCaso { get; set; }

        [JsonProperty("idUsuario")]
        public string ID_Usuario { get; set; }
        public string? UserTypeID { get; set; }
        public DateTime? FechaFirma { get; set; }
        public string? Region { get; set; }
        public string? Local { get; set; }
        public string? Comentarios { get; set; }
        public bool Revertida { get; set; } = false;
        public DateTime? RevertidaFecha { get; set; }
        public string? UsuarioRevierteId { get; set; }
    }
}
