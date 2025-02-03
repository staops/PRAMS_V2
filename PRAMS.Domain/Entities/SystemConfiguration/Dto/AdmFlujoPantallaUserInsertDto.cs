namespace PRAMS.Domain.Entities.SystemConfiguration.Dto
{
    public class AdmFlujoPantallaUserInsertDto
    {
        public AdmFlujoPantallaUserInsertDto(int formularioEtapaId, int prioridad, string? userType, int? groupTypeId, DateTime? fechaInicio, DateTime? fechaFin)
        {
            FormularioEtapaId = formularioEtapaId;
            Prioridad = prioridad;
            UserType = userType;
            GroupTypeId = groupTypeId;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
        public int FormularioEtapaId { get; set; }
        public int Prioridad { get; set; }
        public string? UserType { get; set; }
        public int? GroupTypeId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
