﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFormularioFirmaDto
    {

        public int FormularioFirmasId { get; set; }
        public int FormularioId { get; set; }
        public int FormularioEtapaId { get; set; }
        public string? Rmo { get; set; }
        public string NumCaso { get; set; }
        public string UsuarioId { get; set; }
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
