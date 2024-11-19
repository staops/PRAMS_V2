using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PRAMS.Domain.Entities.Forms.Dto
{
    public class FormFlujoPantallaSPDto
    {
        [JsonProperty("ID_FORM_FlujoPantalla")]
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
        [JsonProperty("ID_Formulario")]
        public int FormularioId { get; set; }

        /// <summary>
        /// El campo de ID_Forma guarda el valor del ID para la llave del formulario que se este trabajando. 
        /// Por ejemplo en el formulario Form_Referido el id que se guarda en este campo seria ID_Referido
        /// </summary>
        [JsonProperty("ID_Forma")]
        public int FormaId { get; set; }
        public int OrdenEtapa { get; set; }
        public string? FlujoEtapa { get; set; }
        [JsonProperty("Fecha_Flujo")]
        public DateTime FechaFlujo { get; set; } = DateTime.Now;
        [JsonProperty("ID_User_Flujo")]
        public string? UsuarioFlujoId { get; set; }
        public string? RMO { get; set; }
        [JsonProperty("Numero_Caso")]
        public string? NumeroCaso { get; set; }
        public string? Persona { get; set; }
        [JsonProperty("ID_User_Asigna")]
        public string? UsuarioAsignaId { get; set; }
        [JsonProperty("ID_User_Asignado")]
        public string? UsuarioAsignadoId { get; set; }
        [JsonProperty("Flujo_Status")]
        public string? FlujoStatus { get; set; }
        public string? Notas { get; set; }
        public string? Comentarios { get; set; }
        public bool EtapaCompletada { get; set; } = false;
        public string? Region { get; set; }
        public string? Local { get; set; }
        public int? rank { get; set; }
        public string?  NombreFlujo { get; set; }
        public string?  NombreAsigna { get; set; }
        public string? NombreAsignado { get; set; }
        public string? NombreSujeto { get; set; }
        public string? NombreRefiere { get; set; }

    }
}
