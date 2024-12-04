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

        public int FormularioId { get; set; }
        public int FormularioEtapaId { get; set; }
        public int? FormaId { get; set; }
        public string? Rmo { get; set; }
        public string NumCaso { get; set; } = string.Empty;
        public string ID_Usuario { get; set; } = string.Empty;
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
