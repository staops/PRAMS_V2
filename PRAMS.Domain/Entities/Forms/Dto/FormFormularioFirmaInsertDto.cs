using Newtonsoft.Json;

namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFormularioFirmaInsertDto
    {
        public FormFormularioFirmaInsertDto() { }
        public FormFormularioFirmaInsertDto(int formularioId, int formularioEtapaId, int? formaId, string? rmo, string? numCaso, string? usuarioId, string? userTypeID, DateTime? fechaFirma, string? region, string? local, string? comentarios, bool revertida, DateTime? revertidaFecha, string? usuarioRevierteId)
        {
            FormularioId = formularioId;
            FormularioEtapaId = formularioEtapaId;
            FormaId = formaId;
            Rmo = rmo;
            NumCaso = numCaso ?? string.Empty;
            ID_Usuario = usuarioId ?? string.Empty;
            UserTypeID = userTypeID;
            FechaFirma = fechaFirma;
            Region = region;
            Local = local;
            Comentarios = comentarios;
            Revertida = revertida;
            RevertidaFecha = revertidaFecha;
            UsuarioRevierteId = usuarioRevierteId;
        }

        [JsonProperty("formularioid")]
        public int FormularioId { get; set; }
        [JsonProperty("formularioetapaid")]
        public int FormularioEtapaId { get; set; }
        [JsonProperty("formaid")]
        public int? FormaId { get; set; }
        [JsonProperty("rmo")]
        public string? Rmo { get; set; }
        [JsonProperty("numCaso")]
        public string NumCaso { get; set; } = string.Empty;
        [JsonProperty("idUsuario")]
        public string ID_Usuario { get; set; } = string.Empty;
        [JsonProperty("userTypeID")]
        public string? UserTypeID { get; set; }
        [JsonProperty("fechaFirma")]
        public DateTime? FechaFirma { get; set; }
        [JsonProperty("region")]
        public string? Region { get; set; }
        [JsonProperty("local")]
        public string? Local { get; set; }
        [JsonProperty("comentarios")]
        public string? Comentarios { get; set; }
        [JsonProperty("revertida")]
        public bool Revertida { get; set; } = false;
        [JsonProperty("revertidaFecha")]
        public DateTime? RevertidaFecha { get; set; }
        [JsonProperty("usuarioRevierteId")]
        public string? UsuarioRevierteId { get; set; }
    }
}
