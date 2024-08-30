namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmFlujoPantallaUserUpdateDto
    {
        public int FlujoUserID { get; set; }
        public int FormularioEtapaId { get; set; }
        public int Prioridad { get; set; }
        public string? UserType { get; set; }
        public int? GroupTypeId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Activo { get; set; } = true;
    }
}
