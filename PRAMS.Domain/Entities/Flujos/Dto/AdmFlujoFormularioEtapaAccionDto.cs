using Newtonsoft.Json;
using PRAMS.Domain.Models.People;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

namespace PRAMS.Domain.Entities.Flujos.Dto
{
    public class AdmFlujoFormularioEtapaAccionDto
    {
        public int FormularioEtapaAccionId { get; set; }
        public required int FormularioEtapaId { get; set; }
        public required string NombreAccion { get; set; }
        public required int OrdenAccion { get; set; }

        /// <summary>
        /// Estamos proyectando tener tres tipos de Acciones que serán definidas para el manejo de las pantallas.
        /// 	Validación Campos – En este caso se usaría para el comienzo de un formulario, en este caso estos pueden ser campos que sean definidos y que sean requeridos el ser llenados para que podamos continuar.Esta definición también podría ser de tablas secundarias como seria la entrada de personas para establecer que tenemos que tener al menos una persona entrada o un tipo de personas o personas entradas en esta validación.
        /// 	Seguimiento Campos – En este caso tendríamos una serie de campos que deben ser llenados, pero el sistema usa esta etapa solo para determinar cuándo pasamos a la próxima etapa.En otras palabras el sistema cuando se accede al formulario para llenar campos compara los que están siendo llenados y determina cuando se completan todos los campos dentro de esta definición y entonces puede pasar a la próxima etapa.
        /// 	Firmas de Personal – En este proceso se define una firma que debe ser realizada por el personal. En este caso podría ser la firma del Trabajador Social. Cada firma debe ser manejada por separado ya que cada firma es una etapa separada del caso que debe ser completada antes de pasar a la próxima firma o a completar el formulario cuando se completen todas las firmas.El proceso que maneja este tipo de Acción debe poder detectar cuando se competan todas las firmas para que puedan ser manejadas.
        /// 	Continuar – Este tipo de definición la tenemos para especificar que este tipo de etapa no requiere validaciones especiales o definiciones de campos a ser validados. Para este tipo cuando se someten los datos se puede pasar a la próxima etapa del caso.
        /// </summary>
        public required string TipoAccion { get; set; }

        public string? TipoProceso { get; set; }

        /// <summary>
        /// El campo de Completado nos indica que esta acción es la completa todas 
        /// las acciones de esta etapa en particular.
        /// Cuando tenemos este campo bit indicado se deben ejecutar los procesos 
        /// para escribir a la tabla Form_FlujosPantallas ya que se completo
        /// </summary>
        public required bool Completado { get; set; } = false;
        public required bool Concurrencia { get; set; } = false;
        public required int ConcurrenciaAccionId { get; set; }
    }
}
