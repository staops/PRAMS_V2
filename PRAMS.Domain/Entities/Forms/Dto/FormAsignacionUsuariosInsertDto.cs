namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormAsignacionUsuariosInsertDto
    {
        public int IdReferido { get; set; }
        public string? Rmo { get; set; }
        public string? NumCaso { get; set; }
        public required string IdUsuario { get; set; }
        public DateTime? FechaEnd { get; set; }
        public string? NivelCaso { get; set; }
        public bool PrincipalTS { get; set; } = false;
        public string? Region { get; set; }
        public string? Local { get; set; }
    }
}
