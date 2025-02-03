﻿using PRAMS.Domain.Models.People;

namespace PRAMS.Domain.Entities.People.Dto
{
    public class PersonDto
    {
        public int PersonaId { get; set; }
        public string? SeguroSocial { get; set; }
        public string? Titulo { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public required string Nombre { get; set; }
        public string? Inicial { get; set; }
        public required string Genero { get; set; }
        public required string Raza { get; set; }
        public required string Etnia { get; set; }
        public required string Ocupacion { get; set; }
        public string? EstadoCivil { get; set; }
        public required string Escolaridad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string LugarNacePueplo { get; set; }
        public required string LugarNaceEstado { get; set; }
        public required string LugarNacePais { get; set; }
        public string? TelefonoResidencia { get; set; }
        public string? TelefonoCelular { get; set; }
        public string? TelefonoFamiliar { get; set; }
        public string? Discapacidad { get; set; }
        public string? Impedimentos { get; set; }
        public bool PretVeterano { get; set; }
        public required string GradAcademico { get; set; }
        public required string Religion { get; set; }
        public string? Email { get; set; }
        public required string CreateUser { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public bool Merged { get; set; } = false;
        public DateTime? MergedDate { get; set; }
        public string? MergedUser { get; set; }
        public int? MergedPersonId { get; set; }
        public virtual ICollection<PersonMergedDto>? MergedPersons { get; set; }
        public virtual PersonMergedDto? MergedPerson { get; set; }

    }
}
