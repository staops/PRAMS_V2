namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormAsignacionUsuariosDto
    {
        public int IdAsignacionUsuario { get; set; }
        public int IdReferido { get; set; }
        public string? Rmo { get; set; }
        public string? NumCaso { get; set; }
        public required string IdUsuario { get; set; }
        public DateTime FechaStart { get; set; }
        public DateTime? FechaEnd { get; set; }
        public string? NivelCaso { get; set; }
        public string? IdUsuarioAsigna { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public bool PrincipalTS { get; set; } = false;
        public bool Activo { get; set; } = true;
        public string? Region { get; set; }
        public string? Local { get; set; }
    }
}
