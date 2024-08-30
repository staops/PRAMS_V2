namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmFlujoPantallaUserDto
    {
        public required int FlujoUserID { get; set; }
        public required int FormularioEtapaId { get; set; }
        public required int Prioridad { get; set; }
        public string? UserType { get; set; }
        public int? GroupTypeId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
