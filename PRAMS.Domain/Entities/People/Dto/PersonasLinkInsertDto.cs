﻿namespace PRAMS.Domain.Entities.People.Dto
{
    public class PersonasLinkInsertDto
    {
        public required int PersonaId { get; set; }
        public required string RMO { get; set; }
        public required string TipoLink { get; set; }
        public string? Relacion { get; set; }
        public bool ViveEnElHogar { get; set; } = false;
        public bool JefeDeFamilia { get; set; } = false;
        public string? EstadoEmpleo { get; set; }
        public bool Pensionado { get; set; } = false;
        public int? ReferidoId { get; set; }
    }
}
