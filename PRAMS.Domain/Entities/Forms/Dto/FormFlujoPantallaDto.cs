namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFlujoPantallaDto
    {
        public int FlujoPantallaId { get; set; }
        /// <summary>
        /// El campo de ID_Formulario proviene de la definición del formulario que este siendo trabajado, 
        /// en este caso sería el mismo ID_Formulario de la tabla Adm_FlujoFormularios
        /// </summary>
        /// <remarks>
        /// Este campo se puede obtener en el controlador de Datos que se este trabajando 
        /// del nombre directo del controlador que debería ser el mismo que la tabla a la que pertenece 
        /// y esta tabla esta identificada en el campo TablaBase de  Adm_FlujoFormularios
        /// </remarks>
        public int FormularioId { get; set; }

        /// <summary>
        /// El campo de ID_Forma guarda el valor del ID para la llave del formulario que se este trabajando. 
        /// Por ejemplo en el formulario Form_Referido el id que se guarda en este campo seria ID_Referido
        /// </summary>
        public int FormaId { get; set; }
        public int OrdenEtapa { get; set; }
        public string? FlujoEtapa { get; set; }
        public DateTime FechaFlujo { get; set; } = DateTime.Now;
        public string? UsuarioFlujoId { get; set; }
        public string? RMO { get; set; }
        public string? NumeroCaso { get; set; }
        public string? Persona { get; set; }
        public string? UsuarioAsignaId { get; set; }
        public string? UsuarioAsignadoId { get; set; }
        public string? FlujoStatus { get; set; }
        public string? Notas { get; set; }
        public string? Comentarios { get; set; }
        public bool EtapaCompletada { get; set; } = false;
        public string? Region { get; set; }
        public string? Local { get; set; }
    }
}
